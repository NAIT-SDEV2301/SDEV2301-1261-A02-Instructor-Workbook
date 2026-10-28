namespace Sdev2301.BlazorIntro.Services
{
    public class TransientMarker
    {
        public Guid InstanceId { get; } = Guid.NewGuid();
    }
}
