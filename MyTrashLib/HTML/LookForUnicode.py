import html

cp = ord("€") # place here in the brackets a char you want to find its Unicode counterpart

print(html.entities.codepoint2name[cp])

# To use the name in your HTML code, you must put an ampersand (&) before the name and
# a semicolon (;) after the name to get the valid HTML entity.