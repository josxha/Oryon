﻿using Microsoft.Extensions.Localization;

namespace KratosSelfService;

public class CustomTranslator(IStringLocalizer<OryElementsTranslator> localizer) : ICustomTranslator
{
    private IStringLocalizer<OryElementsTranslator> Localizer { get; } = localizer;

    public string Get(string text)
    {
        return Localizer[text];
    }
}

public interface ICustomTranslator
{
    string Get(string text);
}