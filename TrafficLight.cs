using PatternStateEducation.State;

namespace PatternStateEducation;

public class TrafficLight
{
    public ITrafficLight? State {get; set;}

    public TrafficLight(ITrafficLight trafficLight)
    {
        State = trafficLight;
    }

    public void PermissiveSignal(){
        State?.PermissiveSignal(this);
    }
    public void ProhibitionSignal(){
        State?.ProhibitionSignal(this);
    }

}
