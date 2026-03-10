# Tushar Variya — Portfolio
### ASP.NET Core Blazor WebAssembly · Deployed on GitHub Pages

---

## 🚀 Deploy to GitHub Pages — Step by Step

Follow these steps **once**. After that, every `git push` to `main` auto-deploys your site.

---

### ✅ Step 1 — Create a GitHub Repository

1. Go to [github.com](https://github.com) and log in
2. Click **"New repository"** (top-right `+` button)
3. Set:
   - **Repository name:** `portfolio`
   - **Visibility:** Public
   - Leave everything else unchecked
4. Click **"Create repository"**

---

### ✅ Step 2 — Update Your Repo Name in the Workflow

Open `.github/workflows/deploy.yml` and find this line:

```yaml
REPO_NAME="portfolio"
```

Change `portfolio` to **your exact GitHub repository name**.

---

### ✅ Step 3 — Push Your Code to GitHub

Open terminal in the `TusharPortfolio` folder:

```bash
git init
git add .
git commit -m "Initial portfolio commit"
git branch -M main
git remote add origin https://github.com/YOUR_USERNAME/portfolio.git
git push -u origin main
```

---

### ✅ Step 4 — Watch the Auto-Deploy

Go to your GitHub repo → **Actions** tab → Watch "Deploy to GitHub Pages" run.

---

### ✅ Step 5 — Enable GitHub Pages

1. Repo → **Settings** → **Pages**
2. Source: `Deploy from a branch`
3. Branch: `gh-pages` → `/ (root)`
4. Click **Save**

---

### ✅ Step 6 — Site is Live!

```
https://YOUR_USERNAME.github.io/portfolio/
```

---

## 🔄 Update Your Site Anytime

```bash
git add .
git commit -m "Update portfolio"
git push
```

Auto-deploys in ~2 minutes. Done!
