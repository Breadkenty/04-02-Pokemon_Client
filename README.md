# Pokemon_Client

<img src="demo.gif" width="350"/>

---

A basic console app that uses the <a href="https://pokeapi.co/">PokemonAPI</a> to display data about pokemon. Some of the features includes:

- Fetches the height and weight of a Pokemon by its name
- Displays all of the type combination's weaknesses and strengths

Technologies used:

- C# and .NET Framework
- Public API

This project primarily focuses on using public APIs to display and manipulate data. In this case, we used a backend language to create a basic console app that uses an API to display information.

# Assignment Overview:

In this project, you will practice accessing an API. You'll see how an API request is made from code, and see how data is returned from an API.

## Objectives

- Demonstrate usage of APIs
- Understand how an API request is sent.
- Understand the request and response for an API.

### Explorer Mode

- [x] TOP TIP: Choose an API that has a simple, less nested API. Perhaps one that just returns an array of one-level-deep objects. This will make your task*significantly* easier.
- [x] Choose one of the APIs from [this list](https://github.com/public-apis/public-apis) that does not request "AUTH" (Authorization) since an API that requires authorization is a little more difficult to use when first learning. I have also selected some sample APIs that will be good choices:

| API                                                      | Documentation                                  |
| -------------------------------------------------------- | ---------------------------------------------- |
| Dogs                                                     | https://dog.ceo/dog-api/                       |
| Studio Ghibli https://ghibliapi.herokuapp.com/#tag/Films |
| Open Brewery                                             | https://www.openbrewerydb.org/                 |
| Recipes                                                  | http://www.recipepuppy.com/about/api/          |
| Deck of Cards!                                           | http://deckofcardsapi.com/                     |
| Geocode                                                  | https://geocode.xyz/api                        |
| Jobs                                                     | https://jobs.github.com/api                    |
| Lyrics                                                   | https://lyricsovh.docs.apiary.io/#reference    |
| Quotes                                                   | https://pprathameshmore.github.io/QuoteGarden/ |
| SpaceX                                                   | https://docs.spacexdata.com/?version=latest    |
| Jokes                                                    | https://github.com/15Dkatz/official_joke_api   |

- [x] After choosing your API **read** the documentation.
- [x] Create a new `sdg-console` application for accessing the API.
- [x] Create a class to store information that comes back from your API.
- [x] Write code to query the API and show results.
- [x] If your API has more than one endpoint (URL) support a few options,
      perhaps by creating a menu system in your application.

## Adventure Mode

Build a command line link shortening tool using this API: https://rel.ink/

Determine for yourself how you would like the tool to work, what the output
would look like, etc.

## Epic Mode

Use the site [Mockaroo](https://mockaroo.com/) to create a mock API. You may
need an account and then learn how their "Mock API" feature works.

Once you have created your Mock API for whatever schema you wish, implement a
client application to work with it.
