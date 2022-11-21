using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CodeArtEng.Gauge.Themes
{
    static class ThemeManager
    {
        private class ThemeRecord
        {
            public ThemeRecord(GaugeTheme name, GaugeThemeBase theme)
            {
                Name = name; ThemeObject = theme;
            }

            public GaugeTheme Name { get; private set; }
            public GaugeThemeBase ThemeObject { get; private set; }
        }
        private static List<ThemeRecord> ThemeRecords;

        /// <summary>
        /// Gauge color scheme when component is disabled (Light Theme)
        /// </summary>
        public static ThemeColors DisabledLight { get; private set; }
        /// <summary>
        /// Gauge color scheme when component is disabled (Dark Theme)
        /// </summary>
        public static ThemeColors DisabledDark { get; private set; }

        static ThemeManager()
        {
            CreateThemeRecords();
            InitiateColors();
        }

        private static void CreateThemeRecords()
        {
            ThemeRecords = new List<ThemeRecord>();
#if !Freeware
            ThemeRecords.Add(new ThemeRecord(GaugeTheme.UserDefined, null));
#endif
            //Scan and register all supported themes type
            Type[] themeTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(n => n.Namespace == "CodeArtEng.Gauge.Themes" && n.IsSubclassOf(typeof(GaugeThemeBase))).ToArray();
            foreach (Type t in themeTypes)
            {
                GaugeThemeBase themeHandler = Activator.CreateInstance(t) as GaugeThemeBase;
                ThemeRecords.Add(new ThemeRecord(themeHandler.ID, themeHandler));
            }
        }
        private static void InitiateColors()
        {
            Color darkPointer = Color.FromArgb(64, 64, 64);
            DisabledDark = new ThemeColors()
            {
                TextForeColor = Color.Black,
                PanelBorderColor = Color.Gray,
                PointerColor = darkPointer,
                PointerBackColor = darkPointer,
                PanelBackColor = darkPointer
            };

            DisabledLight = new ThemeColors()
            {
                TextForeColor = Color.Black,
                PanelBorderColor = Color.Gray,
                PointerColor = Color.Silver,
                PointerBackColor = Color.Silver,
                PanelBackColor = Color.Silver
            };
        }

        /// <summary>
        /// Get Theme handler by name.
        /// </summary>
        /// <param name="theme"></param>
        /// <exception cref="ArgumentOutOfRangeException">GaugeThme not defined, or attempt to get <see cref="GaugeTheme.UserDefined"/> theme.</exception>
        /// <returns></returns>
        public static GaugeThemeBase GetTheme(GaugeTheme theme)
        {
            if (theme == GaugeTheme.NotDefined) return null;
            ThemeRecord r = ThemeRecords.FirstOrDefault(x => x.Name == theme);
            if(r == null) throw new ArgumentOutOfRangeException("Theme", theme, "Theme not supported!");
            return r.ThemeObject;
        }

    }
}
