using CommunityToolkit.Maui.Core;
using DevExpress.Maui.Core.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tessenger.Client.Custom.Algorithms
{
    public class Algorithms : IAlgorithms
    {

        /// <summary>
        ///   Returns a dictionary of countries and their languages
        /// </summary>
        /// <returns>'Dictionary<string, (string CountryName, string Language)>'</returns>
        public Dictionary<string, (string CountryName, string Language)> GetCountryes => new Dictionary<string, (string CountryName, string Language)>()
        {
            { "af-ZA", ("South Africa", "Afrikaans") },
            { "am-ET", ("Ethiopia", "Amharic") },
            { "ar-AE", ("United Arab Emirates", "Arabic") },
            { "ar-BH", ("Bahrain", "Arabic") },
            { "ar-DZ", ("Algeria", "Arabic") },
            { "ar-EG", ("Egypt", "Arabic") },
            { "ar-IQ", ("Iraq", "Arabic") },
            { "ar-JO", ("Jordan", "Arabic") },
            { "ar-KW", ("Kuwait", "Arabic") },
            { "ar-LB", ("Lebanon", "Arabic") },
            { "ar-LY", ("Libya", "Arabic") },
            { "ar-MA", ("Morocco", "Arabic") },
            { "ar-OM", ("Oman", "Arabic") },
            { "ar-QA", ("Qatar", "Arabic") },
            { "ar-SA", ("Saudi Arabia", "Arabic") },
            { "ar-SD", ("Sudan", "Arabic") },
            { "ar-SY", ("Syria", "Arabic") },
            { "ar-TN", ("Tunisia", "Arabic") },
            { "ar-YE", ("Yemen", "Arabic") },
            { "az-AZ", ("Azerbaijan", "Azerbaijani") },
            { "be-BY", ("Belarus", "Belarusian") },
            { "bg-BG", ("Bulgaria", "Bulgarian") },
            { "bn-BD", ("Bangladesh", "Bengali") },
            { "bs-BA", ("Bosnia and Herzegovina", "Bosnian") },
            { "ca-ES", ("Spain", "Catalan") },
            { "cs-CZ", ("Czech Republic", "Czech") },
            { "cy-GB", ("United Kingdom (Welsh)", "Welsh") },
            { "da-DK", ("Denmark", "Danish") },
            { "de-AT", ("Austria", "German") },
            { "de-CH", ("Switzerland", "German") },
            { "de-DE", ("Germany", "German") },
            { "dv-MV", ("Maldives", "Dhivehi") },
            { "el-GR", ("Greece", "Greek") },
            { "en-AU", ("Australia", "English") },
            { "en-CA", ("Canada", "English") },
            { "en-GB", ("United Kingdom", "English") },
            { "en-IN", ("India", "English") },
            { "en-NZ", ("New Zealand", "English") },
            { "en-US", ("United States (English) ", "English") },
            { "en-ZA", ("South Africa", "English") },
            { "es-AR", ("Argentina", "Spanish") },
            { "es-BO", ("Bolivia", "Spanish") },
            { "es-CL", ("Chile", "Spanish") },
            { "es-CO", ("Colombia", "Spanish") },
            { "es-CR", ("Costa Rica", "Spanish") },
            { "es-DO", ("Dominican Republic", "Spanish") },
            { "es-EC", ("Ecuador", "Spanish") },
            { "es-ES", ("Spain", "Spanish") },
            { "es-GT", ("Guatemala", "Spanish") },
            { "es-HN", ("Honduras", "Spanish") },
            { "es-MX", ("Mexico", "Spanish") },
            { "es-NI", ("Nicaragua", "Spanish") },
            { "es-PA", ("Panama", "Spanish") },
            { "es-PE", ("Peru", "Spanish") },
            { "es-PR", ("Puerto Rico", "Spanish") },
            { "es-PY", ("Paraguay", "Spanish") },
            { "es-SV", ("El Salvador", "Spanish") },
            { "es-US", ("United States (Spanish)", "Spanish") },
            { "es-UY", ("Uruguay", "Spanish") },
            { "es-VE", ("Venezuela", "Spanish") },
            { "et-EE", ("Estonia", "Estonian") },
            { "eu-ES", ("Spain", "Basque") },
            { "fa-IR", ("Iran", "Persian") },
            { "fi-FI", ("Finland", "Finnish") },
            { "fil-PH", ("Philippines", "Filipino") },
            { "fo-FO", ("Faroe Islands", "Faroese") },
            { "fr-BE", ("Belgium", "French") },
            { "fr-CA", ("Canada", "French") },
            { "fr-CH", ("Switzerland", "French") },
            { "fr-FR", ("France", "French") },
            { "ga-IE", ("Ireland", "Irish") },
            { "gl-ES", ("Spain", "Galician") },
            { "gu-IN", ("India", "Gujarati") },
            { "ha-NG", ("Nigeria", "Hausa") },
            { "he-IL", ("Israel", "Hebrew") },
            { "hi-IN", ("India", "Hindi") },
            { "hr-HR", ("Croatia", "Croatian") },
            { "hu-HU", ("Hungary", "Hungarian") },
            { "hy-AM", ("Armenia", "Armenian") },
            { "id-ID", ("Indonesia", "Indonesian") },
            { "ig-NG", ("Nigeria", "Igbo") },
            { "is-IS", ("Iceland", "Icelandic") },
            { "it-CH", ("Switzerland", "Italian") },
            { "it-IT", ("Italy", "Italian") },
            { "ja-JP", ("Japan", "Japanese") },
            { "ka-GE", ("Georgia", "Georgian") },
            { "kk-KZ", ("Kazakhstan", "Kazakh") },
            { "km-KH", ("Cambodia", "Khmer") },
            { "kn-IN", ("India", "Kannada") },
            { "ko-KR", ("Korea", "Korean") },
            { "ky-KG", ("Kyrgyzstan", "Kyrgyz") },
            { "lb-LU", ("Luxembourg", "Luxembourgish") },
            { "lo-LA", ("Laos", "Lao") },
            { "lt-LT", ("Lithuania", "Lithuanian") },
            { "lv-LV", ("Latvia", "Latvian") },
            { "mi-NZ", ("New Zealand", "Maori") },
            { "mk-MK", ("Macedonia", "Macedonian") },
            { "ml-IN", ("India", "Malayalam") },
            { "mn-MN", ("Mongolia", "Mongolian") },
            { "mr-IN", ("India", "Marathi") },
            { "ms-MY", ("Malaysia", "Malay") },
            { "mt-MT", ("Malta", "Maltese") },
            { "nb-NO", ("Norway", "Norwegian (Bokmal)") },
            { "ne-NP", ("Nepal", "Nepali") },
            { "nl-BE", ("Belgium", "Dutch") },
            { "nl-NL", ("Netherlands", "Dutch") },
            { "nn-NO", ("Norway", "Norwegian (Nynorsk)") },
            { "no-NO", ("Norway", "Norwegian") },
            { "or-IN", ("India", "Oriya") },
            { "pa-IN", ("India", "Punjabi") },
            { "pl-PL", ("Poland", "Polish") },
            { "prs-AF", ("Afghanistan", "Dari") },
            { "ps-AF", ("Afghanistan", "Pashto") },
            { "pt-BR", ("Brazil", "Portuguese") },
            { "pt-PT", ("Portugal", "Portuguese") },
            { "quz-BO", ("Bolivia", "Quechua") },
            { "ro-RO", ("Romania", "Romanian") },
            { "ru-RU", ("Russia", "Russian") },
            { "rw-RW", ("Rwanda", "Kinyarwanda") },
            { "sd-IN", ("India", "Sindhi") },
            { "si-LK", ("Sri Lanka", "Sinhala") },
            { "sk-SK", ("Slovakia", "Slovak") },
            { "sl-SI", ("Slovenia", "Slovenian") },
            { "sq-AL", ("Albania", "Albanian") },
            { "sr-BA", ("Bosnia and Herzegovina", "Serbian") },
            { "sr-ME", ("Montenegro", "Serbian") },
            { "sr-RS", ("Serbia", "Serbian") },
            { "sv-SE", ("Sweden", "Swedish") },
            { "sw-KE", ("Kenya", "Swahili") },
            { "ta-IN", ("India", "Tamil") },
            { "te-IN", ("India", "Telugu") },
            { "th-TH", ("Thailand", "Thai") },
            { "tk-TM", ("Turkmenistan", "Turkmen") },
            { "tl-PH", ("Philippines", "Tagalog") },
            { "tr-TR", ("Turkey", "Turkish") },
            { "tt-RU", ("Russia", "Tatar") },
            { "ug-CN", ("China", "Uighur") },
            { "uk-UA", ("Ukraine", "Ukrainian") },
            { "ur-PK", ("Pakistan", "Urdu") },
            { "uz-UZ", ("Uzbekistan", "Uzbek") },
            { "vi-VN", ("Vietnam", "Vietnamese") },
            { "wo-SN", ("Senegal", "Wolof") },
            { "xh-ZA", ("South Africa", "Xhosa") },
            { "yo-NG", ("Nigeria", "Yoruba") },
            { "zh-CN", ("China", "Chinese (Simplified)") },
            { "zh-HK", ("Hong Kong", "Chinese (Traditional)") },
            { "zh-TW", ("Taiwan", "Chinese (Traditional)") },
            { "zu-ZA", ("South Africa", "Zulu") }
        };

        /// <summary>
        /// Check if the color is light or dark
        /// </summary>
        /// <param name="color"> </param>
        /// <returns>bool</returns>
        public bool IsColorLight(Color color)
        {
            var Bright = color.GetBrightness();
            if (Bright > 0.5)
            {
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Status bar dynamic Color Change
        /// </summary>
        /// <param name="contentPage"></param>
        /// <param name="Light_color"></param>
        /// <param name="Dark_color"></param>
        /// <param name="isDark"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void StatusBarCustomizetion(ContentPage contentPage, Color Light_color, Color Dark_color)
        {
            Application.Current.RequestedThemeChanged += (s, e) =>
            {
                init(e.RequestedTheme);
            };

          
            init(Application.Current.RequestedTheme);


            void init(AppTheme appTheme)
            {

                if (AppTheme.Dark == appTheme)
                {

                    if (IsColorLight(Dark_color))
                    {
                        contentPage.Behaviors.Add(new CommunityToolkit.Maui.Behaviors.StatusBarBehavior { StatusBarColor = Dark_color, StatusBarStyle = StatusBarStyle.DarkContent });
                    }
                    else
                    {
                        contentPage.Behaviors.Add(new CommunityToolkit.Maui.Behaviors.StatusBarBehavior { StatusBarColor = Dark_color, StatusBarStyle = StatusBarStyle.LightContent });

                    }
                }
                else 
                {
                    if (IsColorLight(Light_color))
                    {
                        contentPage.Behaviors.Add(new CommunityToolkit.Maui.Behaviors.StatusBarBehavior { StatusBarColor = Light_color, StatusBarStyle = StatusBarStyle.DarkContent });
                    }
                    else
                    {
                        contentPage.Behaviors.Add(new CommunityToolkit.Maui.Behaviors.StatusBarBehavior { StatusBarColor = Light_color, StatusBarStyle = StatusBarStyle.LightContent });
                    }
                }
              

            }
        }




    }
}
