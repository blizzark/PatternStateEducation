namespace PatternStateEducation.State;

public interface ITrafficLight
{
    public void Broken(TrafficLight trafficLight){
        Console.WriteLine("Светофор сломался! (Мигающий жёлтый)");
        trafficLight.State = new BrokenLightState();
    }
    public void PermissiveSignal(TrafficLight trafficLight);
    public void ProhibitionSignal(TrafficLight trafficLight);

}
