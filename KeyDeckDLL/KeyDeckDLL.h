#pragma once

#ifdef KEYDECKDLL_EXPORTS
#define KEYDECKDLL_API __declspec(dllexport)
#else
#define KEYDECKDLL_API __declspec(dllimport)
#endif

KEYDECKDLL_API BOOL InstallHook(HWND hwndParent);

KEYDECKDLL_API BOOL UninstallHook();