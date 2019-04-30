using System;
using System.Collections.Generic;

namespace Delivery.Models
{

  public class Parcel
  {
    private string _description;
    private int _height;
    private int _width;
    private int _depth;
    private int _weight;
    private static List<Parcel> _instances = new List<Parcel>{};

    public Parcel(string description, int height, int width, int depth, int weight)
    {
      _description = description;
      _height = height;
      _width = width;
      _depth = depth;
      _weight = weight;
      _instances.Add(this);
    }

    public int GetVolume()
    {
      int parcelVolume = _height * _width * _depth;
      return parcelVolume;
    }

    public int CostToShip()
    {
      int parcelVolume = GetVolume();
      int cost = parcelVolume * _weight * 11;
      return cost;
    }

    public string GetDescription()
    {
      return _description;
    }

    public int GetHeight()
    {
      return _height;
    }

    public int GetWidth()
    {
      return _width;
    }

    public int GetDepth()
    {
      return _depth;
    }

    public int GetWeight()
    {
      return _weight;
    }

    public static List<Parcel> GetAll()
    {
      return _instances;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public void SetHeight(int newHeight)
    {
      _height = newHeight;
    }

    public void SetWidth(int newWidth)
    {
      _width = newWidth;
    }

    public void SetDepth(int newDepth)
    {
      _depth = newDepth;
    }

    public void SetWeight(int newWeight)
    {
      _weight = newWeight;
    }


  }
}
