---
title: 001-auth-strategy
date: 2026-07-02
status: Accepted
---

## Context
The project is currently in an Initial state and runs locally. Core technology choices are set (Next.js + TypeScript for client, C#/.NET for server), but there is no defined working authentication implementation yet.

At this stage, the team needs to keep delivery fast for core API/domain development while avoiding premature identity platform lock-in.

## Decision
For this initial phase, the application will use a No-Auth development strategy:
- No end-user authentication or authorization enforcement in local development flows.
- API endpoints remain open for local POC and integration testing.
- Authentication strategy will be revisited before any shared environment or production deployment.

When auth is introduced, the default direction will be standards-based token auth (OAuth2/OIDC with JWT) enforced at the API boundary.

## Consequences
- Positive: Faster iteration and simpler setup for early development.
- Positive: Lower initial complexity while API/domain foundations stabilize.
- Negative: Security controls are not representative of production behavior.
- Negative: Some future refactoring will be required when auth middleware and policies are added.

Follow-up required:
- Add a future ADR to choose concrete identity provider and token flows.
- Define protected endpoint policy and role/claim model before deployment beyond local use.