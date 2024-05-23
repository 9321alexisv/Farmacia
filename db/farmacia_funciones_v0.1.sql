-- ELIMINAR VENTA Y ACTUALIZAR STOCK DE PRODUCTOS
CREATE OR REPLACE FUNCTION eliminar_venta(venta_eliminar INT)
RETURNS VOID AS $$
BEGIN
    -- Actualizar stock de productos
    WITH productos_venta AS (
        SELECT id_producto, SUM(cantidad) AS cantidad_total
        FROM detalle_venta
        WHERE id_venta = venta_eliminar
        GROUP BY id_producto
    )
    UPDATE producto p
    SET stock = p.stock + pv.cantidad_total
    FROM productos_venta pv
    WHERE p.id_producto = pv.id_producto;

    -- Eliminar los detalles de la venta
    DELETE FROM detalle_venta WHERE id_venta = venta_eliminar;

    -- Eliminar la venta
    DELETE FROM venta WHERE id_venta = venta_eliminar;
END;
$$ LANGUAGE plpgsql;
