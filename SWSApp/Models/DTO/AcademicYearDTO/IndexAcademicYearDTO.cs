using System;
using System.ComponentModel.DataAnnotations;

namespace SWSApp.Models.DTO.AcademicYearDTO;

public class IndexAcademicYearDTO
{
   
    [Display(Name = "شناسه")]
    public int Id { get; set; }
    [Display(Name ="عنوان سال تحصیلی")]
    public string YearTilte { get; set; }
    [Display(Name ="شروع سال تحصیلی")]
    public DateTime StartTime { get; set; }
    [Display(Name ="پایان سال تحصیلی")]
    public DateTime EndTime { get; set; }
    [Display(Name = "وضعیت")]
    public bool IsDeleted { get; set; }

}