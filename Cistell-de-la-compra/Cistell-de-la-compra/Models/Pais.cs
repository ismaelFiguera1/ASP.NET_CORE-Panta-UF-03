﻿namespace Cistell_de_la_compra.Models
{
    public enum Continent
    {
        Asia,
        Europe,
        North_America,
        Africa,
        Oceania,
        Antartica,
        South_America
    }

    public class Pais
    {
        public string  Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Continent Continent { get; set; }
        public string Region { get; set; }
        public double SurfaceArea { get; set; }
        public int IndepYear { get; set; }
        public int Population { get; set; }
        public double Lifeexpectancy { get; set; }
        public double Gnp { get; set; }
        public double GnpOld { get; set; }
        public string Localname { get; set; }
        public string GovernmentForm { get; set; }
        public string HeadofState { get; set; }
        public int Capital { get; set; }
        public string Code2 { get; set; }
    }
}
