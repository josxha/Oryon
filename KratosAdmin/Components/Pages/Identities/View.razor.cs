﻿using KratosAdmin.Services;
using Microsoft.AspNetCore.Components;
using Ory.Client.Model;

namespace KratosAdmin.Components.Pages.Identities;

public partial class View
{
    private List<ClientSession>? _activeSessions;
    private ClientIdentity? _identity;
    private bool _isLoading = true;
    [Parameter] public string? UserId { get; set; }
    [Inject] private ApiService ApiService { get; set; } = default!;

    protected override async Task OnInitializedAsync()
    {
        _identity = await ApiService.IdentityApi.GetIdentityAsync(UserId);
        _activeSessions = await ApiService.IdentityApi.ListIdentitySessionsAsync(UserId, active: true);
        _isLoading = false;
    }

    private void EditIdentity()
    {
        Navigation.NavigateTo($"identities/{UserId}/edit");
    }

    private async Task DeleteIdentity()
    {
        await ApiService.IdentityApi.DeleteIdentityAsync(UserId);
        Navigation.NavigateTo("identities");
    }
}