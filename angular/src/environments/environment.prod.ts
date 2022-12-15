import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'ReservasApp',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44378/',
    redirectUri: baseUrl,
    clientId: 'ReservasApp_App',
    responseType: 'code',
    scope: 'offline_access ReservasApp',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44378',
      rootNamespace: 'Cayman.ReservasApp',
    },
  },
} as Environment;
