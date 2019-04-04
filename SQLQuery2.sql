CREATE PROCEDURE SP_Barang_Add
    @nama_barang [nvarchar](max),
    @harga_barang int,
	@total_barang int
AS
BEGIN
    INSERT INTO barang
    VALUES (
	@nama_barang, 
	@harga_barang, 
	@total_barang
	)  
END

CREATE PROCEDURE SP_Barang_Update
    @kode_barang [int],
    @nama_barang [nvarchar](max),
    @harga_barang int,
	@total_barang int
AS
BEGIN
    UPDATE barang
    SET nama_barang = @nama_barang, 
	harga_barang = @harga_barang,
	total_barang = @total_barang 
    WHERE kode_barang = @kode_barang
END

CREATE PROCEDURE SP_Barang_Delete
    @kode_barang [int]
AS
BEGIN
    DELETE FROM barang
    WHERE kode_barang = @kode_barang
END

CREATE PROCEDURE SP_Barang_Id
@kode_barang int
AS
BEGIN
Select*from barang WHERE kode_barang=@kode_barang
END

CREATE PROCEDURE SP_Barang_All
AS
BEGIN
Select*from barang 
END