CREATE FUNCTION [dbo].[Ft_CostoProducto] (@IdProducto int)
RETURNS decimal(18,4)
AS BEGIN
Declare @idKardex int
declare @Incremento decimal(18,4)
Declare @costo decimal(18,4)

set @idKardex = (select top 1 IdKardex  from pv.Kardex where IdProducto = @IdProducto
order by IdKardex desc)

set @costo=( select CosteoPromedio from pv.CosteoPromedio where IdKardex = @idKardex)

return @costo
END