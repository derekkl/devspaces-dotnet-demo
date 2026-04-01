# Northwind Traders — ASP.NET Core on OpenShift

A demo ASP.NET Core 8 MVC application showcasing [Red Hat Dev Spaces](https://developers.redhat.com/products/dev-spaces/overview) development workflow and deployment to [OpenShift](https://developers.redhat.com/developer-sandbox).

[![Contribute](https://www.eclipse.org/che/contribute.svg)](https://workspaces.openshift.com#https://github.com/derekkl/devspaces-dotnet-demo)

## What's in the demo

- ASP.NET Core 8 MVC with Entity Framework Core
- SQLite database seeded with classic Northwind sample data
- Dashboard, Products (with category filtering), and Categories views
- Devfile for one-click Dev Spaces workspace
- OpenShift S2I build and deployment manifests

## Open in Dev Spaces

Click the badge above, or navigate to your Dev Spaces instance and paste this repo URL.

The workspace will:
1. Pull the `.NET 8` UBI container image
2. Auto-build the project on startup
3. Expose port `8080` for the running app

## Deploy to OpenShift

Log in to your OpenShift cluster, then:

```bash
oc apply -f .openshift/
oc start-build northwind-dotnet --follow
```

Once the build completes, get the app URL:

```bash
oc get route northwind-dotnet
```

## Local development

```bash
cd src/NorthwindApp
dotnet run
# open http://localhost:8080
```
