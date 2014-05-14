﻿using System;
using prep.utility.filtering;

namespace prep.collections
{
  public static class MatcherExtensionForDates
  {
    public static IMatchAn<ItemToMatch> greater_than<ItemToMatch>(this MatcherCreationExtensionPoint<ItemToMatch, DateTime> extension_point, int year, DateValues date_value) 
    {
      if (date_value == DateValues.year)
      {
        throw new NotImplementedException("Finish");
      }
      throw new NotImplementedException("We don't support that yet");
    }
  }

  public class DateValues
  {
    public static readonly DateValues year = new DateValues();
  }
}