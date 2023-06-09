// This file can be replaces during building by using the `fileReplacement`
// `ng build` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.

export const environment = {
    production: false,
    apiUrl: 'https://localhost:5001/api/'
};

/*
 * For easier debuging in development mode, you can import the following
 * to ignore zone related error stack frames such as `zone.run`, `zone.something`
 *
 * This import should be commented out in production mode because it will
 * on performeance if an error is thrown.
 */
// import `zone.js/plugins/zone-error`; // Included with Angular CLI