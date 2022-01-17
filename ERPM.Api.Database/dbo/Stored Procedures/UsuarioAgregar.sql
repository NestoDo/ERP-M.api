-- =============================================
-- Author:		OA
-- Create date: 16/01/2022
-- Description:	Agrega usuario
-- =============================================
CREATE PROCEDURE UsuarioAgregar
	@Nombre				VARCHAR(200) = '',
	@ApellidoPaterno	VARCHAR(200) = '',
	@ApellidoMaterno	VARCHAR(200) = ''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE 
		@Id INT = 0

	INSERT INTO Usuario
	(
		Nombre,
		ApellidoPaterno,
		ApellidoMaterno
	)
	VALUES
	(
		@Nombre,
		@ApellidoPaterno,
		@ApellidoMaterno
	)

	SET @Id = SCOPE_IDENTITY();

	SELECT
		Id,
		Nombre,
		ApellidoPaterno,
		ApellidoMaterno
	FROM Usuario
	WHERE Id = @Id
END
