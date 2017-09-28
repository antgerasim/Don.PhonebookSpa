import { PhoneBookSpaTemplatePage } from './app.po';

describe('abp-project-name-template App', function() {
  let page: PhoneBookSpaTemplatePage;

  beforeEach(() => {
    page = new PhoneBookSpaTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
