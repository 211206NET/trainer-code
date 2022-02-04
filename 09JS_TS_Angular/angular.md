# Angular / SPA (not that Spa)

## SPA: single page application
    - Single page application is an web application that receives all its html/css/js pages in the first request. In subsequent page changes, instead of loading a brand new page, it swaps out part of the page to create a new view. In that sense, there is only "one page" in the application

### Pros?
    - We only need to make one request to get all of our html/css/js assets
    - code reuse
    - subsequent "page loads" are quicker - json is much lighter to transport than html/css/js assets

### Cons?
    - Initial load can be slower because we're getting all our assets in one go
    - initial learning curve/overhead with toolings

## Angular
- Angular is a popular FE framework that creates SPA's. 

### Framework vs Library?
- Both framework and library provides premade solutions to a common problems or tasks
- Framework is more robust solution that contains many more tools for building applications or a complete product(?). Framework in general are more opinionated on how it wants to do certain things.
- Library is lightweight solution that provides tools to solve the problem in hand or tackle a specific tasks. It's less "opinionated" as in, it's less concerned about "how" you should do certain things
- it's somewhat similar to IDE vs code editor

## Getting started with Angular
- First, install angular globally in your machine
    - `npm install -g @angular/cli`
- To initialize an empty angular application
    - `ng new <app-name>`
- To build and run your application
    - `ng serve`
    - `ng serve --open`
        - This opens up the browser at localhost:4200 for you

## Modules
Modules in Angular are similar to namespaces in C# program. It works to bundle various objects under one same roof for easy transportation. Components MUST be registered in one module to be able to be used. If a member of a module require a class or a component from a different module, then the module must be imported in the module.ts file before it can be used by members of that module.
In order to create a new module, `ng generate module <module-name>`

## Components
Components are a named, reusable pieces of view that is bundled with its own logic and styles.
By default they come with 4 files: css, html, ts, spec.ts (testing file)
Ideally, component should only be concerned with user interactions and it should be small and modular (this is our UI layer, so to speak)
In order to create a new component: `ng generate (or g for short) component (c for short) <component-name>`
Components are decorated with @Component decorator that holds metadata about the component, such as selector, templateURL, styleUrls, etc.

## Decorators
Decorators "decorate" plain ts modules and classes or objects to tell angular what angular object it is. It gives additional angular related data to the framework such as type of angular object (ie. modules, component, services, etc) and additional data related to it. There are decorators like @Component, @NgModule, @Injectable, etc.

## Services
Services are... [angular-defn](https://angular.io/guide/architecture-services)

We use services in angular to delegate certain functions that are used commonly across components, such as fetching data from the server, validation, etc. This helps keep component lean and only interested in user interaction.

Create services with `ng generate service <service-name>`

In order to make services part of dep injection, decorate these classes with @Injectable decorator.

## Dependency Injection
Angular provides a built in dep injection, where we can register objects with @Injectable decorator to its dep injection system.
Declare your dependencies in your constructor of the class, and they _magically_ become available!

## Directives
Directives are classes that add additional behavior to elements. Two built in types: structural and attribute.

### Structural directives
Structural directives modify DOM as in, they add or remove html elements.
Some examples of structural directives are `*ngIf`, `*ngFor`, `*ngSwitch` and more

### Attribute directives
Attribute directives doesn't change the structure of DOM. They add or modify attributes - such as ngStyle. (They change or modify the element's appearance or behaviors)

### Promises, Observables
Both of them represent async operations that result in some form of return. Promises are closed after the result has been returned. Once it is fulfilled it's done. Observables use publisher/subscriber model and whenever there are any changes, all subscribers are notified of them.

## Data Binding
- `{{variable.name}}`: interpolation
- `(event)`: Event Binding
- `[property]`: property binding
- `[(two-way)]`: two way binding

## Routes
- create a router module and configure your routes via array that holds route objects. 
- pattern matches
- you can use params via syntax like this /path/to/:param
- query params are not declared in routes array but instead passed when navigating to it
- subscribe to the current route and gain access to its params and query params by using ActivatedRoute
- ```<router-outlet>``` tag acts as a placeholder for the views you want to present depending on your routes.
- different ways to navigate routes: RouterLink (as attributes in your html elements) and using router service, ```router.navigate(['path','names'], routeExtra here like queryParams)```
- you can also directly access the path/component via url ```<a routerLink="path/to/component">Link</a>```

## Angular Testing
To run tests, run `ng test`

### TDD
    Test Driven Development is a development style where we create test first to match our specs, and then we write code to pass those tests

### Jasmine
Jasmine is a default testing framework Angular ships with- it is a behavior driven development framework for testing JS code.
We bundle up the tests in "describe" blocks and tests start with "it" followed by some kind of behavior
[Jasmine](https://jasmine.github.io/)

### Karma
Karma is a test runner that helps us test codes across different web browsers. It also comes with bunch of other super useful config.
[Karma](https://karma-runner.github.io/latest/index.html)

## Other Topics of Interest
- How to pass data between components
    - @Input (From parent to child)
    - @Output: EventEmitter (from child to parent)
    - @ViewChild: When you need access to child's HTML element itself
    - Query Params/params with router
    - utilizing service

- Pipes
    - We use pipes to transform data from one format to another, usually to the ones that can be displayed on the view 
    - We used async pipe to unwrap data from observables, but there are many other pipes
    - date, json, currency, etc..
    - you can create your own as well!

- JS events - how they travel