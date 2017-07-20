namespace _02_Plant
{
    class KyivProvider : PartOperationProvider
    {
        public override void Cast(Part part)
        {
            part.mass += 5;
        }

        public override void Grind(Part part)
        {
            part.roughness -= 2;
        }

        public override void Paint(Part part)
        {
            part.color = "green";
            part.name += "_processed_by_Kyiv";
        }
    }
}
