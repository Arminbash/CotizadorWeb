CREATE procedure spDatosProductosXSegmento(
 @IdSegmento int,
 @Moneda varchar(15)
)
as
begin
	--Declaracion de las variables
	declare @Factor decimal(18,4), @FactorMinimo decimal(18,4), @Precio decimal(18,4), @Costo decimal(18,4), @TasaCambio decimal(18,4)
	declare @PrecioBase decimal(18,4), @PrecioMinimo decimal(18,4)
	declare @TasaOficial decimal(18,4), @TasaParalela decimal(18,4), @IdEmpresa int, @MonedaPrecioProducto varchar(10), @TasaPrecioProducto date,
			@IdProducto int, @Descuento decimal(18,4)

	set @IdEmpresa = (select IdEmpresa from PV.Segmento where IdSegmento = @IdSegmento)

	declare @tbProductos table(
		idProducto int,
		Costo decimal(18,4),
		Precio decimal(18,4),
		Descuento decimal(18,4)
	)

	declare @IvaProd decimal(18,4) = (select IVA from pv.ConfiguracionPV where IdEmpresa = @IdEmpresa)


	declare crsProductos cursor for
	select IdProducto from pv.Producto where IdEmpresa = @IdEmpresa and Estado = 1

	open crsProductos
		fetch next from crsProductos into @IdProducto
		while(@@FETCH_STATUS = 0)
		begin

			set @Factor = (select top(1) factor from PV.PrecioProducto where IdProducto = @IdProducto and IdSegmento = @IdSegmento and Estado = 1 order by IdPrecioProducto desc)
									
			set @Costo = (select [dbo].[Ft_CostoProducto] (@IdProducto))
			if @Factor is null begin set @Factor = 0 end
			
			--Precio del producto con factor
			
			if @Factor <> 0
				begin

					set @FactorMinimo = (select top(1) FactorMinimo from PV.PrecioProducto where IdProducto = @IdProducto and IdSegmento = @IdSegmento and Estado = 1 order by IdPrecioProducto desc)
					set @Descuento = ((@Factor - @FactorMinimo)/@Factor) * 100

					set @Precio = @Costo * @Factor			
				end
			else
				begin
					
					set @PrecioBase = (select PrecioBase from PV.PrecioProducto where IdProducto = @IdProducto and  IdSegmento = @IdSegmento and Estado = 1)
					set @PrecioMinimo = (select PrecioBase from PV.PrecioProducto where IdProducto = @IdProducto and  IdSegmento = @IdSegmento and Estado = 1)

					set @Descuento = ((@PrecioBase - @PrecioMinimo)/@PrecioBase) * 100

					set @MonedaPrecioProducto = (select Moneda from PV.PrecioProducto where IdProducto = @IdProducto and  IdSegmento = @IdSegmento and Estado = 1)
					set @TasaPrecioProducto = (select FechaTasa from PV.PrecioProducto where IdProducto = @IdProducto and  IdSegmento = @IdSegmento and Estado = 1)

					if @MonedaPrecioProducto = 'Dólar'
						begin
							set @Precio = @PrecioBase
						end
					else
						begin
							--Tasa oficial de la fecha en PV.PrecioProducto
							set @TasaOficial = (select [dbo].[getTasaOficial](@IdEmpresa, (select convert(varchar(20),@TasaPrecioProducto))))
							--Tasa Paralela actual
							set @TasaParalela = ((select [dbo].[getTasaParalela](@IdEmpresa, (select convert(varchar(20),convert(date,getdate(),3),103)))))
						
							if @TasaOficial <> 0
								begin
									--Conversión de guardado en dolares a  cordobas del dia al guardado entre tasa al dia (Conversion a equivalente dolar hoy)
									set @Precio = @PrecioBase * @TasaOficial / @TasaParalela	
								end
							else
								begin
									set @Precio = 0
								end						
						end					 
					
				end	

				insert into @tbProductos values(@IdProducto , @Costo, @Precio,@Descuento)

		fetch next from crsProductos into @IdProducto
		end
	close crsProductos
	deallocate crsProductos


	if @Moneda = 'Córdoba'
		begin
		set @tasaCambio  = ( select dbo.getTasaParalela(@IdEmpresa,GETDATE()) )
			
			select prod.IdProducto,prod.CodigoAlterno,prod.CodigoOriginal,
					prod.Nombre,marc.NombreMarca as Marca,linea.Linea,
					rubro.NombreRubro as Rubro,
					 (tb.Costo * @tasaCambio) as Costo, (tb.Precio * @tasaCambio) as Precio,tb.Descuento,
					 iif(prod.TieneIVA = 1,@IvaProd,0) as IVA
			from @tbProductos tb
				inner join pv.Producto prod on prod.IdProducto = tb.idProducto
				inner join pv.Marca marc on marc.IdMarca = prod.IdMarca
				inner join pv.Linea linea on linea.IdLinea = prod.IdLinea
				inner join pv.Rubro rubro on rubro.IdRubro = prod.IdRubro
				where tb.Precio > 0
		end
	else
		begin
			select prod.IdProducto,prod.CodigoAlterno,prod.CodigoOriginal,
					prod.Nombre,marc.NombreMarca as Marca,linea.Linea,
					rubro.NombreRubro as Rubro,
					 tb.Costo, tb.Precio,tb.Descuento,
					 iif(prod.TieneIVA = 1,@IvaProd,0) as IVA
			from @tbProductos tb
				inner join pv.Producto prod on prod.IdProducto = tb.idProducto
				inner join pv.Marca marc on marc.IdMarca = prod.IdMarca
				inner join pv.Linea linea on linea.IdLinea = prod.IdLinea
				inner join pv.Rubro rubro on rubro.IdRubro = prod.IdRubro
				where tb.Precio > 0
		end	
end
