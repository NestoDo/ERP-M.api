-- =============================================
-- Author:		OA
-- Create date: 16/01/2022
-- Description:	Editar usuario
-- =============================================
CREATE PROCEDURE UsuarioEditar
	@Id					INT				= NULL,
	@Nombre				VARCHAR(200)	= '',
	@ApellidoPaterno	VARCHAR(200)	= '',
	@ApellidoMaterno	VARCHAR(200)	= ''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	UPDATE Usuario SET
		Nombre			= @Nombre,
		ApellidoPaterno	= @ApellidoPaterno,
		ApellidoMaterno = @ApellidoMaterno
	WHERE
		Id = @Id

	SELECT
		Id,
		Nombre,
		ApellidoPaterno,
		ApellidoMaterno
	FROM Usuario
	WHERE Id = @Id
END
