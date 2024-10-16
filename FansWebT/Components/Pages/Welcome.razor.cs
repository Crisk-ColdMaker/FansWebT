using BlazorTypewriter;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FansWebT.Components.Pages;
public partial class Welcome
{
    [Inject]
    private NavigationManager? NavigationManager
    {
        get; set;
    }
    private void NavigateTo()
    {
        NavigationManager!.NavigateTo("/home");
    }

    TypewriterBuilder typewriter = new TypewriterBuilder(defaultCharacterPause: 6)
    .TypeString("First line... Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
    .Pause(1000)
    .DeleteAll()
    .TypeString("Second line... Lorem ipsum dolor sit amet, consectetur adipiscing elit.", 50)
    .Pause(500)
    .DeleteAll(30)
    .TypeString("Third line... Lorem ipsum dolor sit amet, consectetur adipiscing elit.", 20)
    .Pause(500)
    .DeleteAll(20)
    .Pause(500)
    .Loop();
    TypewriterBuilder typewriter2 = new TypewriterBuilder(defaultCharacterPause: 6)
    .TypeString("Welcome Amazing Hiki Fans")
    .OneTimePause(5000)
    .Pause(500);
    public string TowerLink = "https://www.bilibili.com/video/BV1z3411w7hX/?spm_id_from=333.999.0.0";
    private Transition transition = Transition.Slide;
}