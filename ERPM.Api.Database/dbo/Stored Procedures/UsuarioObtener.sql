-- =============================================
-- Author:		OA
-- Create date: 16/01/2022
-- Description:	Obtiene usuarios
-- =============================================
CREATE PROCEDURE UsuarioObtener
	@Id INT = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT 
		Id,
		Nombre,
		ApellidoPaterno,
		ApellidoMaterno
	FROM Usuario
	WHERE 
		(@Id = 0 OR Id = @Id)
END
