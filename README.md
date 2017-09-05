[![Build status](https://ci.appveyor.com/api/projects/status/tdt1ejffp8wyl8de?svg=true)](https://ci.appveyor.com/project/marcelrienks/cryptoexchangefarmer)

# Crypto Excahnge Farmer

**_NOTE: this project is very much under development._**

Crypto Excahnge Farmer is a Crypto Currency Farming bot.  

This tool will use configuration information that you specify to automate trades on supported exchanges. The idea with this bot is to make constant small trades, where the bot buys low and sells as high as it can, and in so doing constantly farm small little profits.  

Currently there is no plan to implement any smart algothism to try catch _Big_ trades, this is simply a tool to automate what you would probably be doing manually in day trading

## Getting Started

//TODO:  
These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites

//TODO:  
What things you need to install the software and how to install them

```
Give examples
```

### Installing

//TODO:  
A step by step series of examples that tell you have to get a development env running

Say what the step will be

```
Give the example
```

And repeat

```
until finished
```

End with an example of getting some data out of the system or using it for a little demo

## Running the tests

//TODO:  
Explain how to run the automated tests for this system

## Deployment

//TODO:  
The idea behind creating this bot is that it can be run on any windows machine, and even long term deployed to some kind of cloud platform to allow it to run constantly.

## Built With

//TODO:

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/your/project/tags). 

## Authors

* **Marcel Rienks** - *Initial work* - [PurpleBooth](https://github.com/marcelrienks)

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

# //TODO:
## Logic Flow
0. Buy BTC manually on the Exchange to be used as _Seed_
1. Get Coins
2. Get Prices for Coins
3. Get My Trades
4. Check for _UnExecuted orders_
    * If _UnExecuted orders_ exist  
    TODO: Think of logic for existing orders
    * Else If no _UnExecuted orders_ orders exist  
      Check last trade
        * If last trade was a buy  
        Compare last Buy price to price now
          * If _current price_ is higher than _last buy price_ + **_positive distance_**  
          Create _trailing stop_ at **_positive distance_**
          * Else If _current pricew_ is lower than _last buy price_ - **_negative distance_**  
          Create _stop_ order at _current price_
        * Else If last trade was a Sell  
        TODO: Think of logic for new Buy
