using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheltene
{
    /// <summary>
    /// Class defines a superhero special character traits.
    /// Making properies read-only 
    /// </summary>
    internal class Superhero
    {
        // Attribute list ↓ 
        private string _superHeroName;
        private string _fakeIdentityName;
        private string _power;
        private string _costume;
        private string _team;
        private string _enemy;
        private string _anxiety;

        // Properties. ↓
        public string SuperHeroName
        {
            get { return _superHeroName; }
            private set { _superHeroName = value; }
        }
        public string FakeIdentityName
        {
            get { return _fakeIdentityName; }
            private set { _fakeIdentityName = value; }
        }
        public string Powers
        {
            get { return _power; }
            private set { _power = value; }
        }
        public string Costume
        {
            get { return _costume; }
            private set { _costume = value; }
        }
        public string Team
        {
            get { return _team; }
            private set { _team = value; }
        }
        public string Enemy
        {
            get { return _enemy; }
            private set { _enemy = value; }
        }
        public string Anxiety
        {
            get { return _anxiety; }
            private set { _anxiety = value; }
        }
    }
}
