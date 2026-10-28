namespace Sdev2301.BlazorIntro.Services
{
    public class SingletonMarker
    {
        public Guid InstanceId { get; } = Guid.NewGuid();
    }
}
