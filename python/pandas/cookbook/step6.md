# Rename Method

```
# Load library
import pandas as pd

# Create URL
url = 'https://tinyurl.com/titanic-csv'

# Load data
dataframe = pd.read_csv(url)

# Rename column, show two rows
dataframe.rename(columns={'PClass': 'Passenger Class'}).head(2)
```



```
# Load library
import collections

# Create dictionary
column_names = collections.defaultdict(str)

# Create keys
for name in dataframe.columns:
    column_names[name]

# Show dictionary
column_names
```

#### Output
```
defaultdict(<class 'str'>, {'Name': '', 'PClass': '', 'Age': '', 'Sex': '', 'Survived': '', 'SexCode': ''})
```
