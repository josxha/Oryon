﻿using OryAdmin.Models;

namespace OryAdmin.Components.Layout;

public partial class NavMenu
{
    private bool ServiceEnabled(OryService service)
    {
        return EnvService.ServiceEnabled(service);
    }
}