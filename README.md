# Pokemon_Client

<img src="demo.gif" width="350"/>

# Assignment Overview:

In this project, you will practice accessing an API. You'll see how an API request is made, and see how data is returned from an API

## Objectives

- Demonstrate usage of APIs
- Understand how an API request is sent.
- Understand the request and response for an API.

### Explorer Mode

- [] Choose one of the APIs from
  [this list](https://github.com/public-apis/public-apis) that does not request
  "AUTH" (Authorization) since an API that requires authorization is a little
  more difficult to use when first learning. I have also selected some sample
  APIs that will be good choices:

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
- [x] Use the `Insomnia` tool to make a few queries of the API.
- [x] Capture screenshots from `Insomnia` showing your request and the response
      output.
- [x] Attach those screenshots to your homework assignment.
- [x] For one response, show a screenshot with the "Header" tab displayed.
- [x] For this response, find a few headers and describe what they do. NOTE: If the header starts with `X-` it is a _custom_ header and likely is documented by your API. Other headers are more standard and can be google searched.

## Adventure Mode

Read the documentation on this API: https://one-list-api.herokuapp.com/

Choose your access token from your first and last name. For example `jane-doe`
or `ron-swanson`.

- [x] Use `Insomnia` to insert 6 items in the list associated with your access token. Attach screenshots of the request and results screen.
- [x] Use `Insomnia` to mark 2 of these items complete. Attach screenshots of the request and result screen.
- [x] Use `Insomnia` to delete 1 of the non-complete items. Attach screenshots of the request and result screen.

## Epic Mode

- [ ] Investigate using C#'s `HttpClient` class to make requests to any of the APIs you used in Adventure mode.
- [ ] Create a console app that makes requests and prints the results. Submit the URL to the Github repository of this console app.
