import React from 'react';

import { Section, SectionText, SectionTitle } from '../../styles/GlobalComponents';
import Button from '../../styles/GlobalComponents/Button';
import { LeftSection } from './HeroStyles';

const Hero = (props) => (
  <Section row nopadding>
    <LeftSection>
      <SectionTitle main center>
        Hello, <br />
        I'm Adrian!
      </SectionTitle>
      <SectionText>
        I am a third year bachelor student at UiA Kristiansand where I study information technologies and information systems
      </SectionText>
      <Button onClick={() => window.location = 'https://VG.no'} >Learn More</Button>
    </LeftSection>
  </Section>
);

export default Hero;