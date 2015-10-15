namespace VidyoIntegration.CommonLib.CicTypes.RequestClasses
{
    public class EmailInteractionMediaTypeParameters : MediaTypeParameters
    {
        public override VideoConversationMediaType MediaType
        {
            get { return VideoConversationMediaType.Email; }
        }
    }
}
