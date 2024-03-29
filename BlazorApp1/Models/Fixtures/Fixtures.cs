﻿namespace BlazorApp1.Models.Fixtures
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Newtonsoft.Json;

    public class Fixtures
    {
        [JsonProperty(PropertyName = "api")]
        public Api? Api { get; set; }
    }

    public class Api
    {
        [JsonProperty(PropertyName = "fixtures")]
        public List<Fixture>? Fixtures { get; set; }

        [JsonProperty(PropertyName = "results")]
        public int Results { get; set; }
    }

    public class Fixture
    {
        [JsonProperty(PropertyName = "awayTeam")]
        public Awayteam? Awayteam { get; set; }

        [JsonProperty(PropertyName = "elapsed")]
        public int Elapsed { get; set; }

        [JsonProperty(PropertyName = "event_date")]
        public DateTime EventDate { get; set; }

        [JsonProperty(PropertyName = "event_timestamp")]
        public int EventTimestamp { get; set; }

        [JsonProperty(PropertyName = "firstHalfStart")]
        public int? FirstHalfStart { get; set; }

        [JsonProperty(PropertyName = "fixture_id")]
        public int FixtureId { get; set; }

        [JsonProperty(PropertyName = "goalsAwayTeam")]
        public int? GoalsAwayTeam { get; set; }

        [JsonProperty(PropertyName = "goalsHomeTeam")]
        public int? GoalsHomeTeam { get; set; }

        [JsonProperty(PropertyName = "homeTeam")]
        public Hometeam? HomeTeam { get; set; }

        [JsonIgnore]
        public int HomeTeamId { get; set; }

        [JsonProperty(PropertyName = "league")]
        public League? League { get; set; }

        [JsonProperty(PropertyName = "league_id")]
        public int LeagueId { get; set; }

        [JsonProperty(PropertyName = "referee")]
        public string? Referee { get; set; }

        [JsonProperty(PropertyName = "round")]
        public string? Round { get; set; }

        [JsonProperty(PropertyName = "score")]
        public Score? Score { get; set; }

        [JsonProperty(PropertyName = "secondHalfStart")]
        public int? SecondHalfStart { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string? Status { get; set; }

        [JsonProperty(PropertyName = "statusShort")]
        public string? StatusShort { get; set; }

        [JsonProperty(PropertyName = "venue")]
        public string? Venue { get; set; }
    }

    public class League
    {
        [JsonProperty(PropertyName = "country")]
        public string? Country { get; set; }

        [JsonProperty(PropertyName = "flag")]
        public string? Flag { get; set; }

        [JsonIgnore]
        public int LeagueId { get; set; }

        [JsonProperty(PropertyName = "logo")]
        public string? Logo { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
    }

    public class Hometeam
    {
        [JsonProperty(PropertyName = "logo")]
        public string? Logo { get; set; }

        [JsonProperty(PropertyName = "team_id")]
        [Key]
        public int TeamId { get; set; }

        [JsonProperty(PropertyName = "team_name")]
        public string? TeamName { get; set; }
    }

    public class Awayteam
    {
        [JsonProperty(PropertyName = "logo")]
        public string? Logo { get; set; }

        [JsonProperty(PropertyName = "team_id")]
        [Key]
        public int TeamId { get; set; }

        [JsonProperty(PropertyName = "team_name")]
        public string? TeamName { get; set; }
    }

    public class Score
    {
        [JsonProperty(PropertyName = "extratime")]
        public string? Extratime { get; set; }

        [JsonProperty(PropertyName = "fulltime")]
        public string? Fulltime { get; set; }

        [JsonProperty(PropertyName = "halftime")]
        public string? Halftime { get; set; }

        [JsonProperty(PropertyName = "penalty")]
        public string? Penalty { get; set; }

        [JsonIgnore]
        [Key]
        public int ScoreId { get; set; }
    }
}