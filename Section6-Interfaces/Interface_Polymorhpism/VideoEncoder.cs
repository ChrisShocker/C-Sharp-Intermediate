using System.Collections.Generic;

namespace Interface_Polymorhpism
{
    public class VideoEncoder
    {
        //type dependency we can abstract with an interface
        //-private readonly MailService _mailService;

        private readonly IList<INotifier> _notifiers;

        public VideoEncoder()
        {
            _notifiers = new List<INotifier>();
        }

        public void Encode(Video video)
        {
            foreach(var notifier in _notifiers)
            {
                notifier.Send(new Message());
            }
        }

        public void CreateNotification(INotifier channel)
        {
            _notifiers.Add(channel);
        }
    }
}
