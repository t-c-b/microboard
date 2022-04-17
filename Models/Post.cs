using System;
using System.ComponentModel.DataAnnotations;

public class Post
{
  public int id {get;set;}
  public DateTime time {get;set;}
  public string name {get;set;}
  public string body {get;set;}
}
