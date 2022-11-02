CREATE TABLE [dbo].[Productos] (
    [id_producto]  INT            NOT NULL,
    [descripcion]  NCHAR (10)     NOT NULL,
    [id_categoria] INT            NOT NULL,
    [precio_costo] MONEY   NOT NULL,
    [precio_venta] MONEY   NOT NULL,
    [stock]        MONEY   NOT NULL,
    [stock_min]    MONEY   NOT NULL,
    [imagen]       NVARCHAR (MAX) NULL,
    [eliminado]    NVARCHAR (2)   NOT NULL,
    PRIMARY KEY CLUSTERED ([id_producto] ASC)
);

