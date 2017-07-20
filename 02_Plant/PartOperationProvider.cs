namespace _02_Plant
{
    abstract class PartOperationProvider
    {
        public abstract void Grind(Part part);
        public abstract void Cast(Part part);
        public abstract void Paint(Part part);
        public void PerformStandardSetOfOperations(Part part, Plant plant)
        {
            plant.PerformOperationOnPart(part, Grind);
            plant.PerformOperationOnPart(part, Paint);
            plant.PerformOperationOnPart(part, Cast);
        }
    }
}
