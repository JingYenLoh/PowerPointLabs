﻿using System.Collections.Generic;
using PowerPointLabs.ImagesLab.Domain;

namespace PowerPointLabs.ImagesLab.Factory
{
    class StyleVariantsFactory
    {
        public static Dictionary<string, List<StyleVariants>> GetVariants(string targetStyle)
        {
            switch (targetStyle)
            {
                case TextCollection.ImagesLabText.StyleNameDirectText:
                    return GetVariantsForDirectText();
                case TextCollection.ImagesLabText.StyleNameBlur:
                    return GetVariantsForBlur();
                case TextCollection.ImagesLabText.StyleNameTextBox:
                    return GetVariantsForTextBox();
                case TextCollection.ImagesLabText.StyleNameBanner:
                    return GetVariantsForBanner();
                case TextCollection.ImagesLabText.StyleNameSpecialEffect:
                    return GetVariantsForSpecialEffect();
                case TextCollection.ImagesLabText.StyleNameOverlay:
                    return GetVariantsForOverlay();
                case TextCollection.ImagesLabText.StyleNameOutline:
                    return GetVariantsForOutline();
                case TextCollection.ImagesLabText.StyleNameFrame:
                    return GetVariantsForFrame();
                default:
                    return new Dictionary<string, List<StyleVariants>>();
            }
        }

        private static Dictionary<string, List<StyleVariants>> GetVariantsForFrame()
        {
            return new Dictionary<string, List<StyleVariants>>
            {
                { TextCollection.ImagesLabText.VariantCategoryFrameColor, GetFrameColorVariants() },
                { TextCollection.ImagesLabText.VariantCategoryFrameTransparency, GetFrameTransparencyVariants() },
                { TextCollection.ImagesLabText.VariantCategorySpecialEffects, GetGeneralSpecialEffectVariants() },
                { TextCollection.ImagesLabText.VariantCategoryBlurriness, GetBlurVariants() },
                { TextCollection.ImagesLabText.VariantCategoryBrightness, GetBrightnessVariants() },
                { TextCollection.ImagesLabText.VariantCategoryFontColor, GetFontColorVariants() },
                { TextCollection.ImagesLabText.VariantCategoryTextPosition, GetFontPositionVariants() },
                { TextCollection.ImagesLabText.VariantCategoryFontFamily, GetFontFamilyVariants() },
                { TextCollection.ImagesLabText.VariantCategoryFontSizeIncrease, GetFontSizeIncreaseVariants() }
            };
        }

        private static Dictionary<string, List<StyleVariants>> GetVariantsForOutline()
        {
            return new Dictionary<string, List<StyleVariants>>
            {
                { TextCollection.ImagesLabText.VariantCategoryFontColor, GetFontColorVariants() },
                { TextCollection.ImagesLabText.VariantCategorySpecialEffects, GetGeneralSpecialEffectVariants() },
                { TextCollection.ImagesLabText.VariantCategoryBlurriness, GetBlurVariants() },
                { TextCollection.ImagesLabText.VariantCategoryBrightness, GetBrightnessVariants() },
                { TextCollection.ImagesLabText.VariantCategoryTextPosition, GetFontPositionVariants() },
                { TextCollection.ImagesLabText.VariantCategoryFontFamily, GetFontFamilyVariants() },
                { TextCollection.ImagesLabText.VariantCategoryFontSizeIncrease, GetFontSizeIncreaseVariants() }
            };
        }

        private static Dictionary<string, List<StyleVariants>> GetVariantsForOverlay()
        {
            return new Dictionary<string, List<StyleVariants>>
            {
                { TextCollection.ImagesLabText.VariantCategoryOverlayColor, GetOverlayVariants() },
                { TextCollection.ImagesLabText.VariantCategoryOverlayTransparency, GetOverlayTransparencyVariants() },
                { TextCollection.ImagesLabText.VariantCategoryFontColor, GetFontColorVariants() },
                { TextCollection.ImagesLabText.VariantCategoryTextPosition, GetFontPositionVariants() },
                { TextCollection.ImagesLabText.VariantCategoryFontFamily, GetFontFamilyVariants() },
                { TextCollection.ImagesLabText.VariantCategoryFontSizeIncrease, GetFontSizeIncreaseVariants() }
            };
        }

        private static Dictionary<string, List<StyleVariants>> GetVariantsForSpecialEffect()
        {
            return new Dictionary<string, List<StyleVariants>>
            {
                { TextCollection.ImagesLabText.VariantCategorySpecialEffects, GetSpecialEffectVariants() },
                { TextCollection.ImagesLabText.VariantCategoryBlurriness, GetBlurVariants() },
                { TextCollection.ImagesLabText.VariantCategoryBrightness, GetBrightnessVariants() },
                { TextCollection.ImagesLabText.VariantCategoryFontColor, GetFontColorVariants() },
                { TextCollection.ImagesLabText.VariantCategoryTextPosition, GetFontPositionVariants() },
                { TextCollection.ImagesLabText.VariantCategoryFontFamily, GetFontFamilyVariants() },
                { TextCollection.ImagesLabText.VariantCategoryFontSizeIncrease, GetFontSizeIncreaseVariants() }
            };
        }

        private static Dictionary<string, List<StyleVariants>> GetVariantsForBanner()
        {
            return new Dictionary<string, List<StyleVariants>>
            {
                { TextCollection.ImagesLabText.VariantCategoryBannerColor, GetBannerVariants() },
                { TextCollection.ImagesLabText.VariantCategoryBannerTransparency, GetBannerTransparencyVariants() },
                { TextCollection.ImagesLabText.VariantCategorySpecialEffects, GetGeneralSpecialEffectVariants() },
                { TextCollection.ImagesLabText.VariantCategoryBrightness, GetBrightnessVariants() },
                { TextCollection.ImagesLabText.VariantCategoryFontColor, GetFontColorVariants() },
                { TextCollection.ImagesLabText.VariantCategoryTextPosition, GetFontPositionVariants() },
                { TextCollection.ImagesLabText.VariantCategoryFontFamily, GetFontFamilyVariants() },
                { TextCollection.ImagesLabText.VariantCategoryFontSizeIncrease, GetFontSizeIncreaseVariants() }
            };
        }

        private static Dictionary<string, List<StyleVariants>> GetVariantsForTextBox()
        {
            return new Dictionary<string, List<StyleVariants>>
            {
                { TextCollection.ImagesLabText.VariantCategoryTextBoxColor, GetTextBoxVariants() },
                { TextCollection.ImagesLabText.VariantCategoryTextBoxTransparency, GetTextBoxTransparencyVariants() },
                { TextCollection.ImagesLabText.VariantCategorySpecialEffects, GetGeneralSpecialEffectVariants() },
                { TextCollection.ImagesLabText.VariantCategoryBrightness, GetBrightnessVariants() },
                { TextCollection.ImagesLabText.VariantCategoryFontColor, GetFontColorVariants() },
                { TextCollection.ImagesLabText.VariantCategoryTextPosition, GetFontPositionVariants() },
                { TextCollection.ImagesLabText.VariantCategoryFontFamily, GetFontFamilyVariants() },
                { TextCollection.ImagesLabText.VariantCategoryFontSizeIncrease, GetFontSizeIncreaseVariants() }
            };
        }

        private static Dictionary<string, List<StyleVariants>> GetVariantsForBlur()
        {
            return new Dictionary<string, List<StyleVariants>>
            {
                { TextCollection.ImagesLabText.VariantCategoryBlurriness, GetBlurVariants() },
                { TextCollection.ImagesLabText.VariantCategorySpecialEffects, GetGeneralSpecialEffectVariants() },
                { TextCollection.ImagesLabText.VariantCategoryBrightness, GetBrightnessVariants() },
                { TextCollection.ImagesLabText.VariantCategoryFontColor, GetFontColorVariants() },
                { TextCollection.ImagesLabText.VariantCategoryTextPosition, GetFontPositionVariants() },
                { TextCollection.ImagesLabText.VariantCategoryFontFamily, GetFontFamilyVariants() },
                { TextCollection.ImagesLabText.VariantCategoryFontSizeIncrease, GetFontSizeIncreaseVariants() }
            };
        }

        private static Dictionary<string, List<StyleVariants>> GetVariantsForDirectText()
        {
            return new Dictionary<string, List<StyleVariants>>
            {
                { TextCollection.ImagesLabText.VariantCategoryBrightness, GetBrightnessVariants() },
                { TextCollection.ImagesLabText.VariantCategoryFontColor, GetFontColorVariants() },
                { TextCollection.ImagesLabText.VariantCategoryTextPosition, GetFontPositionVariants() },
                { TextCollection.ImagesLabText.VariantCategoryFontFamily, GetFontFamilyVariants() },
                { TextCollection.ImagesLabText.VariantCategoryFontSizeIncrease, GetFontSizeIncreaseVariants() }
            };
        }

        private static List<StyleVariants> GetOverlayVariants()
        {
            return new List<StyleVariants>
            {
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "White"},
                    {"IsUseOverlayStyle", true},
                    {"OverlayColor", "#FFFFFF"},
                    {"IsUseSpecialEffectStyle", true},
                    {"SpecialEffect", 0}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Black"},
                    {"IsUseOverlayStyle", true},
                    {"OverlayColor", "#000000"},
                    {"IsUseSpecialEffectStyle", true},
                    {"SpecialEffect", 0}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Yellow"},
                    {"IsUseOverlayStyle", true},
                    {"OverlayColor", "#FFCC00"},
                    {"IsUseSpecialEffectStyle", true},
                    {"SpecialEffect", 0}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Red"},
                    {"IsUseOverlayStyle", true},
                    {"OverlayColor", "#FF0000"},
                    {"IsUseSpecialEffectStyle", true},
                    {"SpecialEffect", 0}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Green"},
                    {"IsUseOverlayStyle", true},
                    {"OverlayColor", "#3DFF8F"},
                    {"IsUseSpecialEffectStyle", true},
                    {"SpecialEffect", 0}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Blue"},
                    {"IsUseOverlayStyle", true},
                    {"OverlayColor", "#007FFF"},
                    {"IsUseSpecialEffectStyle", true},
                    {"SpecialEffect", 0}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Purple"},
                    {"IsUseOverlayStyle", true},
                    {"OverlayColor", "#7800FF"},
                    {"IsUseSpecialEffectStyle", true},
                    {"SpecialEffect", 0}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Dark Blue"},
                    {"IsUseOverlayStyle", true},
                    {"OverlayColor", "#001550"},
                    {"IsUseSpecialEffectStyle", true},
                    {"SpecialEffect", 0}
                })
            };
        }

        private static List<StyleVariants> GetOverlayTransparencyVariants()
        {
            return new List<StyleVariants>
            {
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "50% Transparency"},
                    {"IsUseOverlayStyle", true},
                    {"Transparency", 50}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "45% Transparency"},
                    {"IsUseOverlayStyle", true},
                    {"Transparency", 45}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "40% Transparency"},
                    {"IsUseOverlayStyle", true},
                    {"Transparency", 40}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "35% Transparency"},
                    {"IsUseOverlayStyle", true},
                    {"Transparency", 35}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "30% Transparency"},
                    {"IsUseOverlayStyle", true},
                    {"Transparency", 30}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "25% Transparency"},
                    {"IsUseOverlayStyle", true},
                    {"Transparency", 25}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "20% Transparency"},
                    {"IsUseOverlayStyle", true},
                    {"Transparency", 20}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "15% Transparency"},
                    {"IsUseOverlayStyle", true},
                    {"Transparency", 15}
                })
            };
        }

        private static List<StyleVariants> GetSpecialEffectVariants()
        {
            return new List<StyleVariants>
            {
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Grayscale"},
                    {"IsUseSpecialEffectStyle", true},
                    {"SpecialEffect", 0}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Black and White"},
                    {"IsUseSpecialEffectStyle", true},
                    {"SpecialEffect", 1}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Gotham"},
                    {"IsUseSpecialEffectStyle", true},
                    {"SpecialEffect", 3}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "HiSatch"},
                    {"IsUseSpecialEffectStyle", true},
                    {"SpecialEffect", 4}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Invert"},
                    {"IsUseSpecialEffectStyle", true},
                    {"SpecialEffect", 5}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Lomograph"},
                    {"IsUseSpecialEffectStyle", true},
                    {"SpecialEffect", 6}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Polaroid"},
                    {"IsUseSpecialEffectStyle", true},
                    {"SpecialEffect", 8}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Sepia"},
                    {"IsUseSpecialEffectStyle", true},
                    {"SpecialEffect", 9}
                })
            };
        }

        private static List<StyleVariants> GetGeneralSpecialEffectVariants()
        {
            return new List<StyleVariants>
            {
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Grayscale"},
                    {"IsUseSpecialEffectStyle", true},
                    {"SpecialEffect", 0}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Black and White"},
                    {"IsUseSpecialEffectStyle", true},
                    {"SpecialEffect", 1}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Gotham"},
                    {"IsUseSpecialEffectStyle", true},
                    {"SpecialEffect", 3}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "HiSatch"},
                    {"IsUseSpecialEffectStyle", true},
                    {"SpecialEffect", 4}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Invert"},
                    {"IsUseSpecialEffectStyle", true},
                    {"SpecialEffect", 5}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Lomograph"},
                    {"IsUseSpecialEffectStyle", true},
                    {"SpecialEffect", 6}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Polaroid"},
                    {"IsUseSpecialEffectStyle", true},
                    {"SpecialEffect", 8}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "No Effect"},
                    {"IsUseSpecialEffectStyle", false},
                    {"SpecialEffect", -1}
                })
            };
        }

        private static List<StyleVariants> GetFrameColorVariants()
        {
            return new List<StyleVariants>
            {
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "White"},
                    {"FrameColor", "#FFFFFF"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Black"},
                    {"FrameColor", "#000000"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Yellow"},
                    {"FrameColor", "#FFC500"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Red"},
                    {"FrameColor", "#FF0000"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Green"},
                    {"FrameColor", "#3DFF8F"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Blue"},
                    {"FrameColor", "#007FFF"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Purple"},
                    {"FrameColor", "#7800FF"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Dark Blue"},
                    {"FrameColor", "#001550"}
                })
            };
        }

        private static List<StyleVariants> GetBannerVariants()
        {
            return new List<StyleVariants>
            {
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "White"},
                    {"IsUseBannerStyle", true},
                    {"BannerColor", "#FFFFFF"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Black"},
                    {"IsUseBannerStyle", true},
                    {"BannerColor", "#000000"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Yellow"},
                    {"IsUseBannerStyle", true},
                    {"BannerColor", "#FFC500"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Red"},
                    {"IsUseBannerStyle", true},
                    {"BannerColor", "#FF0000"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Green"},
                    {"IsUseBannerStyle", true},
                    {"BannerColor", "#3DFF8F"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Blue"},
                    {"IsUseBannerStyle", true},
                    {"BannerColor", "#007FFF"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Purple"},
                    {"IsUseBannerStyle", true},
                    {"BannerColor", "#7800FF"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Dark Blue"},
                    {"IsUseBannerStyle", true},
                    {"BannerColor", "#001550"}
                })
            };
        }

        private static List<StyleVariants> GetBannerTransparencyVariants()
        {
            return new List<StyleVariants>
            {
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "60% Transparency"},
                    {"IsUseBannerStyle", true},
                    {"BannerTransparency", 60}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "50% Transparency"},
                    {"IsUseBannerStyle", true},
                    {"BannerTransparency", 50}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "40% Transparency"},
                    {"IsUseBannerStyle", true},
                    {"BannerTransparency", 40}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "35% Transparency"},
                    {"IsUseBannerStyle", true},
                    {"BannerTransparency", 35}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "30% Transparency"},
                    {"IsUseBannerStyle", true},
                    {"BannerTransparency", 30}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "25% Transparency"},
                    {"IsUseBannerStyle", true},
                    {"BannerTransparency", 25}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "15% Transparency"},
                    {"IsUseBannerStyle", true},
                    {"BannerTransparency", 15}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "0% Transparency"},
                    {"IsUseBannerStyle", true},
                    {"BannerTransparency", 0}
                })
            };
        }

        private static List<StyleVariants> GetTextBoxVariants()
        {
            return new List<StyleVariants>
            {
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "White"},
                    {"IsUseTextBoxStyle", true},
                    {"TextBoxColor", "#FFFFFF"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Black"},
                    {"IsUseTextBoxStyle", true},
                    {"TextBoxColor", "#000000"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Yellow"},
                    {"IsUseTextBoxStyle", true},
                    {"TextBoxColor", "#FFC500"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Red"},
                    {"IsUseTextBoxStyle", true},
                    {"TextBoxColor", "#FF0000"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Green"},
                    {"IsUseTextBoxStyle", true},
                    {"TextBoxColor", "#3DFF8F"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Blue"},
                    {"IsUseTextBoxStyle", true},
                    {"TextBoxColor", "#007FFF"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Purple"},
                    {"IsUseTextBoxStyle", true},
                    {"TextBoxColor", "#7800FF"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Dark Blue"},
                    {"IsUseTextBoxStyle", true},
                    {"TextBoxColor", "#001550"}
                })
            };
        }

        private static List<StyleVariants> GetTextBoxTransparencyVariants()
        {
            return new List<StyleVariants>
            {
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "60% Transparency"},
                    {"IsUseTextBoxStyle", true},
                    {"TextBoxTransparency", 60}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "50% Transparency"},
                    {"IsUseTextBoxStyle", true},
                    {"TextBoxTransparency", 50}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "40% Transparency"},
                    {"IsUseTextBoxStyle", true},
                    {"TextBoxTransparency", 40}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "35% Transparency"},
                    {"IsUseTextBoxStyle", true},
                    {"TextBoxTransparency", 35}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "30% Transparency"},
                    {"IsUseTextBoxStyle", true},
                    {"TextBoxTransparency", 30}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "25% Transparency"},
                    {"IsUseTextBoxStyle", true},
                    {"TextBoxTransparency", 25}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "15% Transparency"},
                    {"IsUseTextBoxStyle", true},
                    {"TextBoxTransparency", 15}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "0% Transparency"},
                    {"IsUseTextBoxStyle", true},
                    {"TextBoxTransparency", 0}
                })
            };
        }

        private static List<StyleVariants> GetBlurVariants()
        {
            return new List<StyleVariants>
            {
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "100% Blurriness"},
                    {"IsUseBlurStyle", true},
                    {"BlurDegree", 100}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "90% Blurriness"},
                    {"IsUseBlurStyle", true},
                    {"BlurDegree", 95}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "80% Blurriness"},
                    {"IsUseBlurStyle", true},
                    {"BlurDegree", 90}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "70% Blurriness"},
                    {"IsUseBlurStyle", true},
                    {"BlurDegree", 85}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "60% Blurriness"},
                    {"IsUseBlurStyle", true},
                    {"BlurDegree", 80}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "50% Blurriness"},
                    {"IsUseBlurStyle", true},
                    {"BlurDegree", 75}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "40% Blurriness"},
                    {"IsUseBlurStyle", true},
                    {"BlurDegree", 70}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "0% Blurriness"},
                    {"IsUseBlurStyle", true},
                    {"BlurDegree", 0}
                })
            };
        }

        private static List<StyleVariants> GetFrameTransparencyVariants()
        {
            return new List<StyleVariants>
            {
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "0% Transparency"},
                    {"FrameTransparency", 0}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "10% Transparency"},
                    {"FrameTransparency", 10}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "20% Transparency"},
                    {"FrameTransparency", 20}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "30% Transparency"},
                    {"FrameTransparency", 30}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "40% Transparency"},
                    {"FrameTransparency", 40}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "50% Transparency"},
                    {"FrameTransparency", 50}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "60% Transparency"},
                    {"FrameTransparency", 60}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "70% Transparency"},
                    {"FrameTransparency", 70}
                })
            };
        }

        private static List<StyleVariants> GetBrightnessVariants()
        {
            return new List<StyleVariants>
            {
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "140% Brightness"},
                    {"IsUseOverlayStyle", true},
                    {"OverlayColor", "#FFFFFF"},
                    {"Transparency", 60}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "120% Brightness"},
                    {"IsUseOverlayStyle", true},
                    {"OverlayColor", "#FFFFFF"},
                    {"Transparency", 80}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "100% Brightness"},
                    {"IsUseOverlayStyle", true},
                    {"OverlayColor", "#000000"},
                    {"Transparency", 100}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "90% Brightness"},
                    {"IsUseOverlayStyle", true},
                    {"OverlayColor", "#000000"},
                    {"Transparency", 90}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "80% Brightness"},
                    {"IsUseOverlayStyle", true},
                    {"OverlayColor", "#000000"},
                    {"Transparency", 80}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "70% Brightness"},
                    {"IsUseOverlayStyle", true},
                    {"OverlayColor", "#000000"},
                    {"Transparency", 70}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "60% Brightness"},
                    {"IsUseOverlayStyle", true},
                    {"OverlayColor", "#000000"},
                    {"Transparency", 60}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "50% Brightness"},
                    {"IsUseOverlayStyle", true},
                    {"OverlayColor", "#000000"},
                    {"Transparency", 50}
                })
            };
        }

        private static List<StyleVariants> GetFontPositionVariants()
        {
            return new List<StyleVariants>
            {
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Centered"},
                    {"IsUseTextFormat", true},
                    {"TextBoxPosition", 5}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Bottom-left"},
                    {"IsUseTextFormat", true},
                    {"TextBoxPosition", 7}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Left"},
                    {"IsUseTextFormat", true},
                    {"TextBoxPosition", 4}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Original"},
                    {"IsUseTextFormat", true},
                    {"TextBoxPosition", 0}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Bottom"},
                    {"IsUseTextFormat", true},
                    {"TextBoxPosition", 8}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Top-left"},
                    {"IsUseTextFormat", true},
                    {"TextBoxPosition", 1}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Top"},
                    {"IsUseTextFormat", true},
                    {"TextBoxPosition", 2}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Right"},
                    {"IsUseTextFormat", true},
                    {"TextBoxPosition", 6}
                })
            };
        }

        private static List<StyleVariants> GetFontColorVariants()
        {
            return new List<StyleVariants>
            {
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "White"},
                    {"IsUseTextFormat", true},
                    {"FontColor", "#FFFFFF"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Black"},
                    {"IsUseTextFormat", true},
                    {"FontColor", "#000000"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Yellow"},
                    {"IsUseTextFormat", true},
                    {"FontColor", "#FFD700"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Red"},
                    {"IsUseTextFormat", true},
                    {"FontColor", "#FF0000"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Green"},
                    {"IsUseTextFormat", true},
                    {"FontColor", "#3DFF8F"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Blue"},
                    {"IsUseTextFormat", true},
                    {"FontColor", "#007FFF"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Purple"},
                    {"IsUseTextFormat", true},
                    {"FontColor", "#7F00D4"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Dark Blue"},
                    {"IsUseTextFormat", true},
                    {"FontColor", "#001550"}
                })
            };
        }

        private static List<StyleVariants> GetFontFamilyVariants()
        {
            return new List<StyleVariants>
            {
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Segoe UI"},
                    {"IsUseTextFormat", true},
                    {"FontFamily", "Segoe UI"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Calibri"},
                    {"IsUseTextFormat", true},
                    {"FontFamily", "Calibri"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Microsoft YaHei"},
                    {"IsUseTextFormat", true},
                    {"FontFamily", "Microsoft YaHei"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Arial"},
                    {"IsUseTextFormat", true},
                    {"FontFamily", "Arial"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Courier New"},
                    {"IsUseTextFormat", true},
                    {"FontFamily", "Courier New"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Trebuchet MS"},
                    {"IsUseTextFormat", true},
                    {"FontFamily", "Trebuchet MS"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Times New Roman"},
                    {"IsUseTextFormat", true},
                    {"FontFamily", "Times New Roman"}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Tahoma"},
                    {"IsUseTextFormat", true},
                    {"FontFamily", "Tahoma"}
                })
            };
        }

        private static List<StyleVariants> GetFontSizeIncreaseVariants()
        {
            return new List<StyleVariants>
            {
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Original Font Size"},
                    {"IsUseTextFormat", true},
                    {"FontSizeIncrease", 0}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Font Size +3"},
                    {"IsUseTextFormat", true},
                    {"FontSizeIncrease", 3}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Font Size +6"},
                    {"IsUseTextFormat", true},
                    {"FontSizeIncrease", 6}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Font Size +9"},
                    {"IsUseTextFormat", true},
                    {"FontSizeIncrease", 9}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Font Size +12"},
                    {"IsUseTextFormat", true},
                    {"FontSizeIncrease", 12}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Font Size +15"},
                    {"IsUseTextFormat", true},
                    {"FontSizeIncrease", 15}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Font Size +18"},
                    {"IsUseTextFormat", true},
                    {"FontSizeIncrease", 18}
                }),
                new StyleVariants(new Dictionary<string, object>
                {
                    {"OptionName", "Font Size +21"},
                    {"IsUseTextFormat", true},
                    {"FontSizeIncrease", 21}
                })
            };
        }
    }
}
