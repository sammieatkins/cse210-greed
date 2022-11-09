namespace Unit04.Game.Casting{
        /// <summary>
        /// <para>An item of cultural or historical interest.</para>
        /// <para>
        /// The responsibility of an Artifact is to hold it's value.
        /// </para>
        /// </summary>
    class Artifact : Actor{ 
        private int _value;

        /// <summary>
        /// Constructs a new instance of Artifact.
        /// </summary>
        public Artifact(){
        }

        /// <summary>
        /// Sets the value of the artifact. Should be either +1 or -1, declared in Director when all artifacts are constructed.
        /// </summary>
        public void SetValue(int value)
        {
            _value = value;
        }
        
        /// <summary>
        /// Returns the value stored. 
        /// </summary>
        public int GetValue()
        {
            return _value;
        }
    }
}