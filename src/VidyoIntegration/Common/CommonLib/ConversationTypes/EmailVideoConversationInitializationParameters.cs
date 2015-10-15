using ININ.IceLib.Interactions;
using VidyoIntegration.CommonLib.CicTypes;

namespace VidyoIntegration.CommonLib.ConversationTypes
{
    public class EmailVideoConversationInitializationParameters : VideoConversationInitializationParameters
    {
        public override VideoConversationMediaType MediaType
        {
            get { return VideoConversationMediaType.Email; }
            set { }
        }

        public string Content { get; set; }
    }
}