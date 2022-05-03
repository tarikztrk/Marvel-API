using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marvel_Api_Wrapper.Entities
{
    public class MarvelUrls
    {
        public static readonly Uri APIV1 = new("http://gateway.marvel.com/v1/");


        public static Uri Characters() => EUri($"public/characters");
        public static Uri Character(string characterId) => EUri($"public/characters/{characterId}");
        public static Uri CharacterComics(string characterId) => EUri($"public/characters/{characterId}/comics");
        public static Uri CharacterEvents(string characterId) => EUri($"public/characters/{characterId}/events");
        public static Uri CharacterSeries(string characterId) => EUri($"public/characters/{characterId}/series");
        public static Uri CharacterStories(string characterId) => EUri($"public/characters/{characterId}/stories");
        public static Uri Comics() => EUri($"public/comics");
        public static Uri Comic(string comicId) => EUri($"public/comics/{comicId}");
        public static Uri ComicCharacters(string comicId) => EUri($"public/comics/{comicId}/characters");
        public static Uri ComicCreators(string comicId) => EUri($"public/comics/{comicId}/creators");
        public static Uri ComicEvents(string comicId) => EUri($"public/comics/{comicId}/events");
        public static Uri ComicStories(string comicId) => EUri($"public/comics/{comicId}/stories");
        public static Uri Creators() => EUri($"public/creators");
        public static Uri Creator(string creatorId) => EUri($"public/creators/{creatorId}");
        public static Uri CreatorComics(string creatorId) => EUri($"public/creators/{creatorId}/comics");
        public static Uri CreatorEvents(string creatorId) => EUri($"public/creators/{creatorId}/events");
        public static Uri CreatorSeries(string creatorId) => EUri($"public/creators/{creatorId}/series");
        public static Uri CreatorStories(string creatorId) => EUri($"public/creators/{creatorId}/stories");
        public static Uri Events() => EUri($"public/events");
        public static Uri Event(string eventId) => EUri($"public/events/{eventId}");
        public static Uri EventCharacters(string eventId) => EUri($"public/events/{eventId}/characters");
        public static Uri EventComics(string eventId) => EUri($"public/events/{eventId}/comics");
        public static Uri EventCreators(string eventId) => EUri($"public/events/{eventId}/creators");
        public static Uri EventSeries(string eventId) => EUri($"public/events/{eventId}/series");
        public static Uri EventStories(string eventId) => EUri($"public/events/{eventId}/stories");
        public static Uri Series() => EUri($"public/series");
        public static Uri SingleSeries(string seriesId) => EUri($"public/series/{seriesId}");
        public static Uri SingleSeriesCharacters(string seriesId) => EUri($"public/series/{seriesId}/characters");
        public static Uri SingleSeriesComics(string seriesId) => EUri($"public/series/{seriesId}/comics");
        public static Uri SingleSeriesCreators(string seriesId) => EUri($"public/series/{seriesId}/creators");
        public static Uri SingleSeriesEvents(string seriesId) => EUri($"public/series/{seriesId}/events");
        public static Uri SingleSeriesStories(string seriesId) => EUri($"public/series/{seriesId}/stories");
        public static Uri Stories() => EUri($"public/stories");
        public static Uri Story(string storyId) => EUri($"public/stories/{storyId}");
        public static Uri StoryCharacters(string storyId) => EUri($"public/stories/{storyId}/characters");
        public static Uri StoryComics(string storyId) => EUri($"public/stories/{storyId}/comics");
        public static Uri StoryCreators(string storyId) => EUri($"public/stories/{storyId}/creators");
        public static Uri StoryEvents(string storyId) => EUri($"public/stories/{storyId}/events");
        public static Uri StorySeries(string storyId) => EUri($"public/stories/{storyId}/series");

        private static Uri EUri(FormattableString path) => new($"{APIV1}{path}");

    }
}
