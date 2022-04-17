try:
    from BeautifulSoup4 import BeautifulSoup
except ImportError:
    from bs4 import BeautifulSoup

with open("input.html") as html:

    parsed_html = BeautifulSoup(html)
