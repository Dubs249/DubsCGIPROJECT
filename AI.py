import google.generativeai as genai
import os

genai.configure(api_key=os.getenv("GOOGLE_API_KEY"))
model = genai.GenerativeModel('gemini-pro')

message1= """
Generate 4 groups of 4 words, in which each group has a common thread, Hard difficulty, display the correlation, keep the following format:
**Group 1:**
* text
* text
* text
* text

**Correlation:** text

**Group 2:**
* text
* text
* text
* text

**Correlation:** text

**Group 3:**
* text
* text
* text
* text

**Correlation:** text

**Group 4:**
* text
* text
* text
* text"""



response = model.generate_content(message1)


temps = str(response.text)

f = open('datahold.txt','w')
f.writelines(temps)
f.close()


