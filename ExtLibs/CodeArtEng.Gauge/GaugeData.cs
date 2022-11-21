using System;
using System.ComponentModel;

namespace CodeArtEng.Gauge
{
    /// <summary>
    /// Gauge Data class
    /// </summary>
    [Browsable(false)]
    [DesignTimeVisible(false)]
    [ToolboxItem(false)]
    public class GaugeData : Component
    {
        public static GaugeData Default()
        {
            return new GaugeData()
            {
                Name = "(Default)",
                Maximum = 200,
                Minimum = 0,
                Value = 88,
                Unit = "km/h",
                WarningLimit = 120,
                ErrorLimit = 160,
                InvertLimit = false
            };
        }

        string name;
        [Browsable(false)]
        public string Name
        {
            get
            {
                if (Site != null)
                    name = Site.Name;
                return name;
            }
            set
            {
                if (Site != null)
                    Site.Name = value;
                name = value;
            }
        }

        public override string ToString()
        {
            return name;
        }

        /// <summary>
        /// Limit / unit changed, except value.
        /// </summary>
        public event EventHandler PropertyChanged;
        protected void OnPropertyChanged() { PropertyChanged?.Invoke(this, null); }

        /// <summary>
        /// Value changed event
        /// </summary>
        public event EventHandler ValueChanged;

        /// <summary>
        /// Remove all subscribed event handlers
        /// </summary>
        internal void ClearValueAndPropertyChangedEventHandlers()
        {
            if (ValueChanged != null)
            {
                foreach (EventHandler d in ValueChanged.GetInvocationList())
                    ValueChanged -= d;
            }

            if(PropertyChanged != null)
            {
                foreach (EventHandler d in PropertyChanged.GetInvocationList())
                    PropertyChanged -= d;
            }

        }

        private void ValidateValue()
        {
            _Value = Math.Max(_Minimum, _Value);
            _Value = Math.Min(_Maximum, _Value);
        }

        protected void SetValue<T>(ref T property, T value)
        {
            if (property.Equals(value)) return;
            property = value;
            OnPropertyChanged();
        }

        /// <summary>
        /// Get or set minimum value of pointer.
        /// </summary>
        public double Minimum
        {
            get => _Minimum;
            set
            {
                _Minimum = value;
                _Maximum = Math.Max(_Maximum, _Minimum);
                ValidateValue();
                OnPropertyChanged();
            }
        }
        private double _Minimum = 0;

        /// <summary>
        /// Get or set maximum value of pointer.
        /// </summary>
        public double Maximum
        {
            get => _Maximum;
            set
            {
                _Maximum = value;
                _Minimum = Math.Min(_Minimum, _Maximum);
                ValidateValue();
                OnPropertyChanged();
            }
        }
        private double _Maximum = 100;

        /// <summary>
        /// Gauge value
        /// </summary>
        public double Value
        {
            get => _Value;
            set
            {
                if (_Value == value) return;
                double prevValue = _Value;
                _Value = value;
                ValueChanged?.Invoke(this, null);
            }
        }
        private double _Value = 0;

        [Browsable(false)]
        internal double OldValue { get; private set; } = 0;

        /// <summary>
        /// Unit Text.
        /// </summary>
        public string Unit
        {
            get => _Unit;
            set => SetValue(ref _Unit, value);
        }
        private string _Unit = string.Empty;

        /// <summary>
        /// Change pointer to PointerWarningColor when value goes beyond warning limit. Set value to NAN to disable warning limit.
        /// </summary>
        public double WarningLimit
        {
            get => _WarningLimit;
            set => SetValue(ref _WarningLimit, value);
        }
        private double _WarningLimit = double.NaN;

        /// <summary>
        /// Change pointer to PointerErrorColor when value goes beyond error limit. Set value to NAN to disable error limit.
        /// </summary>
        public double ErrorLimit
        {
            get => _ErrorLimit;
            set => SetValue(ref _ErrorLimit, value);
        }
        private double _ErrorLimit = double.NaN;

        /// <summary>
        /// When enable, warning or error is triggered when value fall below limit.
        /// </summary>
        public bool InvertLimit { get; set; } = false;
    }
}
