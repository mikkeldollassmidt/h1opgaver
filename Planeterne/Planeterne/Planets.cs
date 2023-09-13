using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Planeterne
{
    public class Planets
    {
        private string _name;
        private float _mass;
        private float _diameter;
        private float _density;
        private float _gravity;
        private float _rotationPeriod;
        private float _lengthOfDay;
        private float _distanceFromSun;
        private float _orbitalPeriod;
        private float _orbitalVelocity;
        private float _meanTemperature;
        private float _numberOfMoons;
        private bool _ringSystem;

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }
        public float Mass
        {
            get { return _mass; }
            private set { _mass = value; }
        }
        public float Diameter
        {
            get { return _diameter; }
            private set { _diameter = value; }
        }
        public float Density
        {
            get { return _density; }
            private set { _density = value; }
        }
        public float Gravity
        {
            get { return _gravity; }
            private set { _gravity = value; }
        }
        public float RotationPeriod
        {
            get { return _rotationPeriod; }
            private set { _rotationPeriod = value; }
        }
        public float LengthOfDay
        {
            get { return _lengthOfDay; }
            private set { _lengthOfDay = value; }
        }
        public float DistanceFromSun
        {
            get { return _distanceFromSun; }
            private set { _distanceFromSun = value; }
        }
        public float OrbitalPeriod
        {
            get { return _orbitalPeriod; }
            private set { _orbitalPeriod = value; }
        }
        public float OrbitalVelocity
        {
            get { return _orbitalVelocity; }
            private set { _orbitalVelocity = value; }
        }
        public float MeanTemperature
        {
            get { return _meanTemperature; }
            private set { _meanTemperature = value; }
        }
        public float NumberOfMoons
        {
            get { return _numberOfMoons; }
            private set { _numberOfMoons = value; }
        }
        public bool RingSystem
        {
            get { return _ringSystem; }
            private set { _ringSystem = value; }
        }

        public Planets(string name, float mass, float diameter, float density, float gravity, float rotationPeriod, float lengthOfDay, float distanceFromSun, float orbitalPeriod, float orbitalVelocity, float meanTemperature, float numberOfMoons, bool ringSystem)
        {
            _name = name;
            _mass = mass;
            _diameter = diameter;
            _density= density;
            _gravity = gravity;
            _rotationPeriod = rotationPeriod;
            _lengthOfDay = lengthOfDay;
            _distanceFromSun = distanceFromSun;
            _orbitalPeriod= orbitalPeriod;
            _orbitalVelocity= orbitalVelocity;
            _meanTemperature= meanTemperature;
            _numberOfMoons= numberOfMoons; 
            _ringSystem= ringSystem;
        }
    }
}
