namespace _02_Plant
{
    class Part
    {
        public string name;
        public string materialName;
        public int roughness;
        public string color;
        public double mass;

        public Part(string name = "Some_part", string materialName = "Metal", int roughness = 10, string color = "black", double mass = 3.5)
        {
            this.name = name;
            this.materialName = materialName;
            this.roughness = roughness;
            this.color = color;
            this.mass = mass;
        }

        public override string ToString()
        {
            string result = "";
            result += "Part name: " + name + "; "; 
            result += "Material = " + materialName + "; ";
            result += "roughness = " + roughness + "; ";
            result += "color: " + color + "; ";
            result += "mass = " + mass + ".";
            return result;
        }
    }
}
