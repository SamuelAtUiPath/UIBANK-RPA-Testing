# UIBANK RPA Testing — Windows Process Project

Workshop project for the **RPA Testing Workshop** (4 hours, Automation Cloud, RPA developer audience). The system under test is **UiBank**, UiPath's public demo banking application. This repo is both the system under test's automation *and* the test suite for it — that duality is the point.

> [!IMPORTANT]
> This is a **Windows Process** project, not cross-platform and not a Test Automation project. Both choices are deliberate and neither is safe to change. See [Why this shape](#why-this-shape) before touching `project.json`.

---

## Why this shape

| Decision | Reason | Consequence |
|---|---|---|
| **Process** project, not Test Automation | Mock activities are unavailable in Test Automation projects. The Automation testing entitlement also covers tests built inside Process projects — that's the licence line this audience sits on | Tests live inside the developer's own project and repo. That *is* the adoption message |
| **Windows** target, not cross-platform | Mock activities are unavailable in cross-platform projects (verified in tenant, 2026-09-18) | Studio Desktop only; no serverless runtimes; `UiPath.CLI.Windows` for CI |
| Excel / Mail / O365 dependencies kept | They work on Windows | `Loan_Application_Test_Data.xlsx` is usable as a live data-variation source |
| `Verify Control Attribute` used as-is | Available on Windows | Login assertions did not need rewriting around Get Text |

What the Windows choice costs: serverless execution, Studio Web authoring, Linux CI runners, and the `.uip`-through-Studio-Web distribution route. Execution needs a VM-based cloud robot or the participant's own machine.

---

## Layout

```
UIBANK RPA Testing_Windows/
├── Main.xaml                  entry point — the one end-to-end path
├── project.json               Windows / Process / 6 publishable test cases
├── UiBank/                    the automation under test
│   ├── UiBank_Login.xaml
│   ├── UiBank_ApplyforLoan.xaml       ← the main subject of the day
│   ├── UiBank_CheckLoanDetails.xaml
│   └── UiBank_Logout.xaml
├── Tests/
│   ├── Login/                 3 unit tests
│   ├── ApplyForLoan/          1 unit test + 1 data-driven
│   └── IntegrationTests/      1 integration test
├── Mocks/
│   ├── UiBank/UiBank_Login_mock.xaml
│   └── mock_config.json
├── Bad-Examples/              excluded from publish — teaching artefacts only
│   ├── monolith-main.xaml
│   └── UiBank_Login_BadExampleOfTesting.xaml
├── TestData/                  CSV, JSON, XLSX, queue schema
├── .variations/               data-variation bindings
├── .tmh/                      Test Manager link config
└── Docs/                      PDD and SDD for UiBank loan submission
```

---

## Test cases

All six are marked **Publishable** in `project.json`. Naming follows `Workflow_Scenario_ExpectedResult`; bodies follow explicit Given / When / Then.

| Test case | Level | Workshop chapter |
|---|---|---|
| `Login_ValidCredentials_Success` | Unit | 05 — first unit test |
| `Login_WrongCredentials_ThrowException` | Unit | 05 |
| `Login_HomeNotReached_ThrowException` | Unit | 05 / 07 — the one that runs with UiBank unreachable |
| `ApplyforLoan_EligibleApplicant_LoanApproved` | Unit | 05 / 06 |
| `ApplyforLoan_DataDriven` | Unit, data-driven | 08 — bound to `.variations/Loan_Application_Test_Data_Sheet1.json` |
| `ApplyForLoan_CheckLoan_Integration` | Integration | 09 — the seam between apply and read-back |

---

## The deliberate flaws

Two assets exist only to be criticised in the room. Both are in `processOptions.ignoredFiles` so they never reach a published package.

| File | Used by | What it demonstrates |
|---|---|---|
| `Bad-Examples/monolith-main.xaml` | Chapter 04 | A recorded end-to-end Flowchart with no seams. Nothing in it can be tested in isolation — this is the "before" that motivates extraction |
| `Bad-Examples/UiBank_Login_BadExampleOfTesting.xaml` | Chapter 04 | The `in_TestMode` boolean anti-pattern. Test-aware production code: it makes the test pass and the production path unverified |

> [!NOTE]
> Open facilitator decision: whether the `% APR` contract mismatch in `UiBank_ApplyforLoan` stays broken. It is the day's only genuine defect discovery and it is what makes chapter 09 land. Decide before the session, not during it.

---

## Running this

**Prerequisites**

- Studio Desktop, Windows compatibility. Studio Web will not open this project.
- Automation Developer (Pro) licence — grants "Build RPA test automations" and RPA-scoped Test Manager access. App Tester licences are the Test Cloud side and are *not* this.
- Tenant on Standard tier or above, for the Automation testing row.
- Orchestrator credential asset `UiBank_Credentials` in the project's default folder.
- `Allow legacy execution context` **off**.

**Common commands**

```
uip rpa get-errors  --project-dir "<this folder>"
uip rpa run-file    --file-path "Main.xaml" --project-dir "<this folder>"
```

Tests run from **Test Explorer** in Studio, or as a test set from Test Manager against a Windows runtime. There is no serverless option — a VM-based cloud robot or a local machine is required.

---

## Related material

Workshop chapters live in the knowledge base at `20 Knowledge Base/Test Automation/RPA Testing Workshop/Chapters/`. Start at **RPA Testing Workshop - Hub** for the agenda, the constraint set, and the facilitator prep checklist. **RPA Testing Workshop - UiBank Process Project Conversion** records how this project got its current shape — what was kept from the source Test Automation project, what was dropped, and what was rewritten.

Chapter-to-asset mapping, in running order: 04 uses `Bad-Examples/`; 05 builds the Login tests; 07 uses `Mocks/`; 08 uses `TestData/` and `.variations/`; 09 uses `Tests/IntegrationTests/`; 10 runs everything as a test set from Test Manager; 03 works from `Docs/`.

> [!WARNING]
> `CLAUDE.md` in this folder carries an auto-generated project-context block that is **stale**. It still reports the target framework as Portable, `Tests/` as empty, zero test cases, and `monolith-main.xaml` at the project root. Regenerate it or read `project.json` instead.
