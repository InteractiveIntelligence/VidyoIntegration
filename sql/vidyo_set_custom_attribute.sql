-- ================================================
-- Stores a custom attribute from an interaction
-- to a screen recording
-- ================================================
USE I3_IC

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Pierrick Lozach
-- Create date: 10/19/2015
-- =============================================
CREATE PROCEDURE vidyo_set_custom_attribute
	@RecordingGuid uniqueidentifier,
	@CustomAttributeName nvarchar(255),
	@CustomAttributeValue nvarchar(255)
AS
BEGIN

	SET NOCOUNT ON;

	DECLARE @CustomAttributeNameId int

	-- Insert AttributeName if it does not exist
	IF (SELECT COUNT(*) FROM IR_CustomAttributeName WHERE Name=@CustomAttributeName) = 0
	BEGIN
		INSERT INTO IR_CustomAttributeName (Name) VALUES (@CustomAttributeName)
	END

	-- Get Custom Attribute Name Id
	SET @CustomAttributeNameId = (SELECT CustomAttributeNameId FROM IR_CustomAttributeName WHERE Name = @CustomAttributeName)

	-- Insert Custom Attribute Value
	INSERT INTO IR_CustomAttribute
		(RecordingId, CustomAttributeNameId, Value, Version) VALUES
		(@RecordingGuid, @CustomAttributeNameId, @CustomAttributeValue, 1)

END
GO
