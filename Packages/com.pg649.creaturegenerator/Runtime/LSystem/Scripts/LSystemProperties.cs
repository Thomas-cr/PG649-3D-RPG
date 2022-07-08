﻿namespace LSystem
{
    /// <summary>
    /// Struct for passing properties of the lsystem to another object.
    /// </summary>
    public struct LSystemProperties
    {
        public readonly float distance;
        public readonly short angle;
        public readonly INITIAL_DIRECTION initialDirection;
        public readonly float thickness;
        public readonly uint crossSections;
        public readonly uint crossSectionDivisions;

        public readonly bool translatePoints;
        public readonly string startString;
        public readonly uint iterations;

        public readonly string[] rules;

        public LSystemProperties(float distance, short angle, INITIAL_DIRECTION initialDirection, float thickness, uint crossSections, uint crossSectionDivisions, bool translatePoints, string startString, uint iterations, string[] rules)
        {
            this.distance = distance;
            this.angle = angle;
            this.initialDirection = initialDirection;
            this.thickness = thickness;
            this.crossSections = crossSections;
            this.crossSectionDivisions = crossSectionDivisions;
            this.translatePoints = translatePoints;
            this.startString = startString;
            this.iterations = iterations;
            this.rules = rules;
        }
    }
}