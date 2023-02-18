import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'CurrenyProject',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44380/',
    redirectUri: baseUrl,
    clientId: 'CurrenyProject_App',
    responseType: 'code',
    scope: 'offline_access CurrenyProject',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44355',
      rootNamespace: 'CurrenyProject',
    },
  },
} as Environment;
