USE [emili]
GO

DECLARE	@return_value Int,
		@NextCMHCNO int

EXEC	@return_value = [dbo].[GetNextCMHCNo]
		@NextCMHCNO = @NextCMHCNO out

SELECT	@NextCMHCNO as N'@NextCMHCNO'

SELECT	@return_value as 'Return Value'

GO
