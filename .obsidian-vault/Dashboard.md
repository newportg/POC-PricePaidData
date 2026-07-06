# Project Dashboard

## 🐛 Open Bugs
```dataview
TABLE status, file.mtime as "Last updated"
FROM "bugs"
WHERE status = "Open"
SORT file.mtime DESC
```

## 📋 Open Specs
```dataview
TABLE status
FROM "specs"
WHERE status != "Done"
```

## 🗺️ Recent Decisions
```dataview
TABLE file.mday as "Date"
FROM "decisions"
SORT file.mday DESC
LIMIT 5
```