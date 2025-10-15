using Microsoft.Playwright;
using SportBettingScraper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportBettingScraper.Core;
public static class PlayWrightScraper
{
    public static async Task<string> GetFixtures(string leagueUrl)
    {
        // Launch headless Chromium browser
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new() { Headless = true });

        var page = await browser.NewPageAsync();
        await page.GotoAsync(leagueUrl, new() { WaitUntil = WaitUntilState.NetworkIdle });

        // Wait for fixture list to load (selector verified as of 2025)
        await page.WaitForSelectorAsync("text=Favourites");

        // Extract full text of the page (fully rendered)
        var text = await page.InnerTextAsync("body");

        return text;

    }
}
