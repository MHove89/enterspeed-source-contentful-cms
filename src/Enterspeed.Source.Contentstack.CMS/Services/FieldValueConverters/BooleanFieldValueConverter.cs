﻿using Enterspeed.Source.Contentstack.CMS.Models;
using Enterspeed.Source.Sdk.Api.Models.Properties;

namespace Enterspeed.Source.Contentstack.CMS.Services.FieldValueConverters;

public class BooleanFieldValueConverter : IEnterspeedFieldValueConverter
{
    public bool IsConverter(ContentstackField field)
    {
        return field.Type == typeof(bool);
    }

    public IEnterspeedProperty Convert(ContentstackField field)
    {
        bool.TryParse(field.Value.ToString(), out var boolean);

        return new BooleanEnterspeedProperty(field.Name, boolean);
    }
}