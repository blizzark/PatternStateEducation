namespace PatternStateEducation.State;

public interface ITrafficLight
{
    public void PermissiveSignal(TrafficLight trafficLight);
    public void ProhibitionSignal(TrafficLight trafficLight);

}
