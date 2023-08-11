using System.ComponentModel.DataAnnotations;

namespace GalleryWebsite.Models;

public class Image
{
    public int Id { get; set; }
    public string? Location { get; set; }
    public DateTime DateTime { get; set; }
    public string? Photographer { get; set; }
    public string? Tags { get; set; }
}